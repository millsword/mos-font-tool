using MosFontTool.Common;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MosFontTool.Common
{
    /// <summary>
    /// Color mode
    /// </summary>
    public enum COLOR_MODE
    {
        UNKONOWN,
        MONO,
        GRAY4BITS,
        RGB565,
        RGB565P
    }

    /// <summary>
    /// Scan mode
    /// </summary>
    public enum SCAN_MODE
    {
        UNKOWN,
        ROW_SCAN,
        COLUMN_SCAN
    }

    public class FontDrawExtend
    {
        const int PADDING_LEFT = 45;
        const int PADDING_TOP = 3;
        const int PADDING_BOTTOM = 3;
        const int BLOCK_MARGIN = 3;
        const int SCROLL_STEP = 3;
        const int ROWS_OF_LARGE_SCROLL = 3;


        /// <summary>
        /// Get scroll maximum value, used for reset vScrollbar when font parameters changed
        /// </summary>
        /// <param name="height">picturebox client height</param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static int getScrollMaximum(int height, FontSettings settings)
        {
            int rowHeight = settings.BlockHeight + BLOCK_MARGIN;
            int rows = settings.Chars.Length / 16;
            if (settings.Chars.Length % 16 > 0) rows++;

            int blockTotalHeight = rows * rowHeight;
            int workHeight = height - PADDING_TOP - PADDING_BOTTOM;
            // pad to full page
            blockTotalHeight += (blockTotalHeight % workHeight);

            int steps = (blockTotalHeight + SCROLL_STEP) / SCROLL_STEP;
            return steps > 0 ? steps : 1;
        }

        /// <summary>
        /// Get scroll largeChange value, for reset vScrollbar when font parameters changed
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static int getScrollLargeChange(FontSettings settings, int height)
        {
            int largeScrollHeight = ROWS_OF_LARGE_SCROLL * (settings.BlockHeight + BLOCK_MARGIN);
            int workHeight = height - PADDING_BOTTOM - PADDING_TOP;
            if (largeScrollHeight > workHeight)
            {
                largeScrollHeight = workHeight;
            }
            return largeScrollHeight / SCROLL_STEP;
        }

        /// <summary>
        /// Get char's index by position of content image
        /// </summary>
        /// <remarks>
        /// if outrange return -1
        /// </remarks>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="scrollOffset"></param>
        /// <param name="settings"></param>
        /// <returns>chars string index</returns>
        public static int getCurrentCharIndex(int x, int y, int scrollOffset, FontSettings settings)
        {
            // convert to font draw region's location
            x -= PADDING_LEFT;
            y = y - PADDING_TOP + scrollOffset * SCROLL_STEP;

            // outrange return -1
            if (x < 0 || y < 0) return -1;

            // calculate row index
            int rows = y / (settings.BlockHeight + BLOCK_MARGIN);
            // calculate column index
            int cols = x / (settings.BlockWidth + BLOCK_MARGIN);

            // outrange of columns return -1
            if (cols >= 16) return -1;

            // get index of chars string
            int pos = rows * 16 + cols;

            // if greate than chars length return -1
            pos = pos >= settings.Chars.Length ? -1 : pos;

            return pos;
        }

        /// <summary>
        /// Zoom image to new size, return new bitmap object
        /// </summary>
        /// <param name="src"></param>
        /// <param name="newSize"></param>
        /// <returns></returns>
        public static Bitmap ZoomBmp(Bitmap src, Size newSize)
        {
            Bitmap bmpZoom = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics g = Graphics.FromImage(bmpZoom))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(src, 0, 0, bmpZoom.Width, bmpZoom.Height);
            }

            return bmpZoom;
        }

        /// <summary>
        /// return a bitmap which drawed a char
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="charPos"></param>
        /// <returns></returns>
        public static Bitmap DrawChar(FontSettings settings, int charPos)
        {
            Bitmap bmp = new Bitmap(settings.BlockWidth, settings.BlockHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                DrawChar(g, settings, settings.Chars[charPos]);
            }
            return bmp;
        }

        /// <summary>
        /// Draw a char in given graphics
        /// </summary>
        /// <param name="g"></param>
        /// <param name="settings"></param>
        /// <param name="c"></param>
        public static void DrawChar(Graphics g, FontSettings settings, char c)
        {
            g.TextRenderingHint = settings.RenderingHint;
            g.Clear(settings.BackColor);
            TextRenderer.DrawText(g, c.ToString(), settings.Font,
                new Rectangle(settings.OffsetX, settings.OffsetY, settings.BlockWidth, settings.BlockHeight),
                settings.Forecolor, settings.BackColor, settings.TextFormatFlags);
        }
        /// <summary>
        /// Draw content view's image
        /// </summary>
        /// <param name="g">Graphics of Content picturebox</param>
        /// <param name="height">picturebox's client height</param>
        /// <param name="settings"></param>
        /// <param name="scrollOffset">vScrollbar's value</param>
        public static void DrawContentImage(Graphics g, int height, FontSettings settings, int scrollOffset)
        {
            int charIndex = getCurrentCharIndex(PADDING_LEFT, PADDING_TOP, scrollOffset, settings);
            if (charIndex == -1) return;

            scrollOffset *= SCROLL_STEP;
            int workHeight = height - PADDING_TOP - PADDING_BOTTOM;
            int rowHeight = settings.BlockHeight + BLOCK_MARGIN;
            int columnWidth = settings.BlockWidth + BLOCK_MARGIN;
            int rows = workHeight / rowHeight + 1;
            int rowOffset = scrollOffset % rowHeight;
            if (rowOffset > 0) rows++;

            g.Clear(Properties.Settings.Default.ContentBackColor);
            using (Bitmap bmp = new Bitmap(settings.BlockWidth, settings.BlockHeight))
            {
                using (Graphics frame = Graphics.FromImage(bmp))
                {
                    int x = PADDING_LEFT, y = PADDING_TOP;
                    Rectangle rectCopy = new Rectangle(0, rowOffset, bmp.Width, bmp.Height - rowOffset);
                    Rectangle rectIndex = new Rectangle(0, rowOffset > 0 ? y - rowOffset : y, PADDING_LEFT, bmp.Height);
                    int charCount = settings.Chars.Length;
                    //for (int row = 0; row < rows; row++)
                    while(y < height - PADDING_BOTTOM)
                    {
                        // out of range, break
                        if (charIndex >= charCount) break;

                        // display row index
                        TextRenderer.DrawText(g, 
                            ((charIndex / 16).ToString("X4")), 
                            Properties.Settings.Default.RowIndexFont, rectIndex,
                            Properties.Settings.Default.RowIndexColor, Properties.Settings.Default.ContentBackColor,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                        for (int column = 0; column < 16; column++)
                        {
                            if (charIndex >= charCount) break;

                            DrawChar(frame, settings, settings.Chars[charIndex++]);
                            g.DrawImage(bmp, x, y, rectCopy, GraphicsUnit.Pixel);
                            x += columnWidth;
                        }

                        // after clip first row, reset copy rectangle
                        if (PADDING_TOP == y)
                        {
                            rectCopy.Y = 0;
                            rectCopy.Height = bmp.Height;
                        }

                        x = PADDING_LEFT;
                        y += (PADDING_TOP == y ? (rowHeight - rowOffset) : rowHeight);
                        rectIndex.Y += rowHeight;

                        // clip last row
                        if (y + rowHeight> height - PADDING_BOTTOM)
                        {
                            rectCopy.Height = height - PADDING_BOTTOM - y;
                        }
                    }

                    // clear row index
                    Brush b = new SolidBrush(Color.Red);//Properties.Settings.Default.ContentBackColor);
                    g.FillRectangle(b, 0, 0, PADDING_LEFT, PADDING_TOP);
                    g.FillRectangle(b, 0, height - PADDING_BOTTOM, PADDING_LEFT, PADDING_BOTTOM);
                }
            }
        }

        /// <summary>
        /// Get one char's font data by given bitmap
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="colorMode"></param>
        /// <param name="scanMode"></param>
        /// <returns></returns>
        public static List<byte> getCharFontData(Bitmap bmp, COLOR_MODE colorMode, SCAN_MODE scanMode)
        {
            List<byte> bytes = new List<byte>();
            List<Color> colors = new List<Color>();
            int outsideInitValue, insideInitValue;
            int outsideStopValue, insideStopValue;
            int outsideStep, insideStep;
            bool loopOutsideIsX = true;

            switch (scanMode)
            {
                case SCAN_MODE.ROW_SCAN:
                    outsideInitValue = 0;
                    outsideStopValue = bmp.Height;
                    outsideStep = 1;
                    insideInitValue = 0;
                    insideStopValue = bmp.Width;
                    insideStep = 1;
                    break;
                case SCAN_MODE.COLUMN_SCAN:
                    outsideInitValue = 0;
                    outsideStopValue = bmp.Width;
                    outsideStep = 1;
                    insideInitValue = 0;
                    insideStopValue = bmp.Height;
                    insideStep = 1;
                    break;
                default:
                    throw new ArgumentException(Properties.Resources.Err_invalidateScanMode);
            }

            // scan font bitmap
            for(int i=outsideInitValue; i!=outsideStopValue; i+=outsideStep)
            {
                for(int j=insideInitValue; j!=insideStopValue; j+=insideStep)
                {
                    if (loopOutsideIsX)
                    {
                        colors.Add(bmp.GetPixel(i, j));
                    }
                    else
                    {
                        colors.Add(bmp.GetPixel(j, i));
                    }
                    j++;
                }
                // convert to byte every row or column
                bytes.AddRange(color2byte(colors, colorMode));
                colors.Clear();
                i++;
            }

            return bytes;
        }

        /// <summary>
        /// Convert color value to byte in given color mode.
        /// </summary>
        /// <remarks>
        /// if can't fill a byte then pad zero at last
        /// </remarks>
        /// <param name="colors">color datas</param>
        /// <param name="colorMode"></param>
        /// <returns></returns>
        public static List<byte> color2byte(List<Color> colors, COLOR_MODE colorMode)
        {
            List<byte> bytes = new List<byte>();

            switch (colorMode)
            {
                case COLOR_MODE.MONO:
                    {
                        byte b = 0, mask = 0x80;
                        foreach (Color color in colors)
                        {
                            if (Misc.isBlackLikely(color))
                            {
                                b |= mask;
                            }
                            mask >>= 1;
                            if (mask == 0)
                            {
                                bytes.Add(b);
                                //Debug.Write(string.Format("c={0};={1:X2}\t\t", color.ToArgb().ToString("X8").Substring(2), b));
                                b = 0;
                                mask = 0x80;
                            }
                        }

                        // if can't fill a byte, pad zero to right
                        if (mask != 0)
                        {
                            bytes.Add(b);
                        }
                    }
                    break;
                case COLOR_MODE.GRAY4BITS:
                    {
                        byte b = 0;
                        bool isHighBits = true;
                        foreach (Color color in colors)
                        {
                            if (isHighBits)
                            {
                                b = (byte)(Misc.getGrayScale(color) & 0xf0);
                            }
                            else
                            {
                                b |= (byte)(Misc.getGrayScale(color));
                                bytes.Add(b);
                                //Debug.Write(string.Format("c={0};={1:X2}\t\t", color.ToArgb().ToString("X8").Substring(2), b));
                                b = 0;
                            }
                            isHighBits = !isHighBits;
                        }

                        // if can't fill a byte. pad zero
                        bytes.Add(b);
                    }
                    break;
                case COLOR_MODE.RGB565:
                    foreach (Color color in colors)
                    {
                        UInt16 value = Misc.getRGB565(color);
                        bytes.AddRange(BitConverter.GetBytes(value));
                        //Debug.Write(string.Format("c={0};={1:X2}\t\t", color.ToArgb().ToString("X8").Substring(2), value));
                    }
                    break;
                case COLOR_MODE.RGB565P:
                    foreach (Color color in colors)
                    {
                        UInt16 value = Misc.getRGB565P(color);
                        bytes.AddRange(BitConverter.GetBytes(value));
                        //Debug.Write(string.Format("c={0};={1:X2}\t\t", color.ToArgb().ToString("X8").Substring(2), value));
                    }
                    break;
                default:
                    throw new ArgumentException(Properties.Resources.Err_invalidateColorMode);
            }

            //Debug.WriteLine("====one line scaned", "color2byte()");

            return bytes;
        }

        private static int getFirstRowIndex(FontSettings settings, int offset)
        {
            if (offset < PADDING_TOP + settings.BlockHeight)
            {
                return 0;
            }

            int rows = (offset - PADDING_TOP) / (settings.BlockHeight + BLOCK_MARGIN);
            return rows;
        }
    }
}
