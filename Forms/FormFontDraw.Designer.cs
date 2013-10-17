namespace MosFontTool
{
    partial class FormFontDraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (pictureBoxPage.Image != null)
            {
                pictureBoxPage.Image.Dispose();
                graphicsOfContent.Dispose();
            }
            if (pictureBoxZoom.Image != null)
            {
                pictureBoxZoom.Image.Dispose();
            }
            if (fontSettings != null)
            {
                fontSettings.Dispose();
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.listBoxSystemFont = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBoxSize = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxFilterChars = new System.Windows.Forms.CheckBox();
            this.checkBoxSortChars = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertNewLine = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreNewLine = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxBackgroundColor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxForecolor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trackBarOffsetY = new System.Windows.Forms.TrackBar();
            this.trackBarOffsetX = new System.Windows.Forms.TrackBar();
            this.trackBarBlockHeight = new System.Windows.Forms.TrackBar();
            this.trackBarBlockWidth = new System.Windows.Forms.TrackBar();
            this.buttonResetBlock = new System.Windows.Forms.Button();
            this.numericUpDownOffsetY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOffsetX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlockHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlockWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxArrayName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButtonColumn1 = new System.Windows.Forms.RadioButton();
            this.radioButtonRow1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColorPicker = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFontViewer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxCharInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlockHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlockWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockWidth)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel6.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxZoom.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxZoom.Location = new System.Drawing.Point(17, 22);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxZoom.TabIndex = 0;
            this.pictureBoxZoom.TabStop = false;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(793, 248);
            this.pictureBoxPage.TabIndex = 1;
            this.pictureBoxPage.TabStop = false;
            this.pictureBoxPage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPage_MouseClick);
            // 
            // listBoxSystemFont
            // 
            this.listBoxSystemFont.FormattingEnabled = true;
            this.listBoxSystemFont.ItemHeight = 14;
            this.listBoxSystemFont.Location = new System.Drawing.Point(52, 11);
            this.listBoxSystemFont.Name = "listBoxSystemFont";
            this.listBoxSystemFont.Size = new System.Drawing.Size(184, 144);
            this.listBoxSystemFont.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(256, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Style";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 18);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Italic + Bold";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 18);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Bold";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Italic";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Regular";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBoxSize
            // 
            this.listBoxSize.FormattingEnabled = true;
            this.listBoxSize.ItemHeight = 14;
            this.listBoxSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.listBoxSize.Location = new System.Drawing.Point(430, 11);
            this.listBoxSize.Name = "listBoxSize";
            this.listBoxSize.Size = new System.Drawing.Size(111, 144);
            this.listBoxSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 559);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.vScrollBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 301);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(819, 258);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxPage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 248);
            this.panel4.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(798, 5);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 248);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 301);
            this.panel2.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.richTextBoxCharInput);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 198);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(819, 103);
            this.panel8.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(819, 198);
            this.panel5.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tabControl1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(631, 198);
            this.panel7.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 198);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.listBoxSystemFont);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxSize);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Font Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxFilterChars);
            this.tabPage3.Controls.Add(this.checkBoxSortChars);
            this.tabPage3.Controls.Add(this.checkBoxInsertNewLine);
            this.tabPage3.Controls.Add(this.checkBoxIgnoreNewLine);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(623, 171);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Font Additions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterChars
            // 
            this.checkBoxFilterChars.AutoSize = true;
            this.checkBoxFilterChars.Location = new System.Drawing.Point(385, 99);
            this.checkBoxFilterChars.Name = "checkBoxFilterChars";
            this.checkBoxFilterChars.Size = new System.Drawing.Size(181, 18);
            this.checkBoxFilterChars.TabIndex = 6;
            this.checkBoxFilterChars.Text = "Filtering duplicate characters";
            this.checkBoxFilterChars.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortChars
            // 
            this.checkBoxSortChars.AutoSize = true;
            this.checkBoxSortChars.Location = new System.Drawing.Point(385, 76);
            this.checkBoxSortChars.Name = "checkBoxSortChars";
            this.checkBoxSortChars.Size = new System.Drawing.Size(81, 18);
            this.checkBoxSortChars.TabIndex = 5;
            this.checkBoxSortChars.Text = "Sort chars";
            this.checkBoxSortChars.UseVisualStyleBackColor = true;
            this.checkBoxSortChars.CheckedChanged += new System.EventHandler(this.checkBoxSortChars_CheckedChanged);
            // 
            // checkBoxInsertNewLine
            // 
            this.checkBoxInsertNewLine.AutoSize = true;
            this.checkBoxInsertNewLine.Location = new System.Drawing.Point(385, 52);
            this.checkBoxInsertNewLine.Name = "checkBoxInsertNewLine";
            this.checkBoxInsertNewLine.Size = new System.Drawing.Size(99, 18);
            this.checkBoxInsertNewLine.TabIndex = 4;
            this.checkBoxInsertNewLine.Text = "Insert \'\\r\' \'\\n\'";
            this.checkBoxInsertNewLine.UseVisualStyleBackColor = true;
            this.checkBoxInsertNewLine.CheckedChanged += new System.EventHandler(this.checkBoxInsertNewLine_CheckedChanged);
            // 
            // checkBoxIgnoreNewLine
            // 
            this.checkBoxIgnoreNewLine.AutoSize = true;
            this.checkBoxIgnoreNewLine.Location = new System.Drawing.Point(385, 28);
            this.checkBoxIgnoreNewLine.Name = "checkBoxIgnoreNewLine";
            this.checkBoxIgnoreNewLine.Size = new System.Drawing.Size(103, 18);
            this.checkBoxIgnoreNewLine.TabIndex = 3;
            this.checkBoxIgnoreNewLine.Text = "Ignore \'\\r\' \'\\n\'";
            this.checkBoxIgnoreNewLine.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreNewLine.CheckedChanged += new System.EventHandler(this.checkBoxIgnoreNewLine_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton12);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Location = new System.Drawing.Point(189, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 129);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Anti-aliasing";
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(7, 103);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(65, 18);
            this.radioButton12.TabIndex = 3;
            this.radioButton12.Text = "System";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(7, 79);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(79, 18);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.Text = "ClearType";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 55);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 18);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "TrueType";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 31);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 18);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Pixel";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxBackgroundColor);
            this.groupBox3.Location = new System.Drawing.Point(8, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BackgroundColor";
            // 
            // textBoxBackgroundColor
            // 
            this.textBoxBackgroundColor.Location = new System.Drawing.Point(23, 21);
            this.textBoxBackgroundColor.Name = "textBoxBackgroundColor";
            this.textBoxBackgroundColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxBackgroundColor.TabIndex = 0;
            this.textBoxBackgroundColor.Text = "ff000000";
            this.textBoxBackgroundColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBackgroundColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForecolor_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxForecolor);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forecolor";
            // 
            // textBoxForecolor
            // 
            this.textBoxForecolor.Location = new System.Drawing.Point(23, 22);
            this.textBoxForecolor.Name = "textBoxForecolor";
            this.textBoxForecolor.Size = new System.Drawing.Size(100, 22);
            this.textBoxForecolor.TabIndex = 0;
            this.textBoxForecolor.Text = "ffffffff";
            this.textBoxForecolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxForecolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForecolor_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trackBarOffsetY);
            this.tabPage2.Controls.Add(this.trackBarOffsetX);
            this.tabPage2.Controls.Add(this.trackBarBlockHeight);
            this.tabPage2.Controls.Add(this.trackBarBlockWidth);
            this.tabPage2.Controls.Add(this.buttonResetBlock);
            this.tabPage2.Controls.Add(this.numericUpDownOffsetY);
            this.tabPage2.Controls.Add(this.numericUpDownOffsetX);
            this.tabPage2.Controls.Add(this.numericUpDownBlockHeight);
            this.tabPage2.Controls.Add(this.numericUpDownBlockWidth);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Block Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trackBarOffsetY
            // 
            this.trackBarOffsetY.LargeChange = 3;
            this.trackBarOffsetY.Location = new System.Drawing.Point(368, 123);
            this.trackBarOffsetY.Maximum = 15;
            this.trackBarOffsetY.Minimum = -15;
            this.trackBarOffsetY.Name = "trackBarOffsetY";
            this.trackBarOffsetY.Size = new System.Drawing.Size(104, 42);
            this.trackBarOffsetY.TabIndex = 6;
            this.trackBarOffsetY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOffsetY.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // trackBarOffsetX
            // 
            this.trackBarOffsetX.LargeChange = 3;
            this.trackBarOffsetX.Location = new System.Drawing.Point(368, 95);
            this.trackBarOffsetX.Maximum = 15;
            this.trackBarOffsetX.Minimum = -15;
            this.trackBarOffsetX.Name = "trackBarOffsetX";
            this.trackBarOffsetX.Size = new System.Drawing.Size(104, 42);
            this.trackBarOffsetX.TabIndex = 6;
            this.trackBarOffsetX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOffsetX.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // trackBarBlockHeight
            // 
            this.trackBarBlockHeight.LargeChange = 3;
            this.trackBarBlockHeight.Location = new System.Drawing.Point(396, 54);
            this.trackBarBlockHeight.Maximum = 15;
            this.trackBarBlockHeight.Minimum = -15;
            this.trackBarBlockHeight.Name = "trackBarBlockHeight";
            this.trackBarBlockHeight.Size = new System.Drawing.Size(211, 42);
            this.trackBarBlockHeight.TabIndex = 6;
            this.trackBarBlockHeight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlockHeight.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // trackBarBlockWidth
            // 
            this.trackBarBlockWidth.LargeChange = 3;
            this.trackBarBlockWidth.Location = new System.Drawing.Point(396, 25);
            this.trackBarBlockWidth.Maximum = 15;
            this.trackBarBlockWidth.Minimum = -15;
            this.trackBarBlockWidth.Name = "trackBarBlockWidth";
            this.trackBarBlockWidth.Size = new System.Drawing.Size(211, 42);
            this.trackBarBlockWidth.TabIndex = 6;
            this.trackBarBlockWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlockWidth.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // buttonResetBlock
            // 
            this.buttonResetBlock.Location = new System.Drawing.Point(532, 126);
            this.buttonResetBlock.Name = "buttonResetBlock";
            this.buttonResetBlock.Size = new System.Drawing.Size(75, 23);
            this.buttonResetBlock.TabIndex = 5;
            this.buttonResetBlock.Text = "Reset Block Settings";
            this.buttonResetBlock.UseVisualStyleBackColor = true;
            this.buttonResetBlock.Click += new System.EventHandler(this.buttonResetBlock_Click);
            // 
            // numericUpDownOffsetY
            // 
            this.numericUpDownOffsetY.AllowDrop = true;
            this.numericUpDownOffsetY.Location = new System.Drawing.Point(261, 124);
            this.numericUpDownOffsetY.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownOffsetY.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.numericUpDownOffsetY.Name = "numericUpDownOffsetY";
            this.numericUpDownOffsetY.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownOffsetY.TabIndex = 4;
            this.numericUpDownOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownOffsetY.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // numericUpDownOffsetX
            // 
            this.numericUpDownOffsetX.AllowDrop = true;
            this.numericUpDownOffsetX.Location = new System.Drawing.Point(261, 95);
            this.numericUpDownOffsetX.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownOffsetX.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.numericUpDownOffsetX.Name = "numericUpDownOffsetX";
            this.numericUpDownOffsetX.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownOffsetX.TabIndex = 3;
            this.numericUpDownOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownOffsetX.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // numericUpDownBlockHeight
            // 
            this.numericUpDownBlockHeight.AllowDrop = true;
            this.numericUpDownBlockHeight.Location = new System.Drawing.Point(261, 54);
            this.numericUpDownBlockHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownBlockHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBlockHeight.Name = "numericUpDownBlockHeight";
            this.numericUpDownBlockHeight.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownBlockHeight.TabIndex = 2;
            this.numericUpDownBlockHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownBlockHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownBlockHeight.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // numericUpDownBlockWidth
            // 
            this.numericUpDownBlockWidth.AllowDrop = true;
            this.numericUpDownBlockWidth.Location = new System.Drawing.Point(261, 25);
            this.numericUpDownBlockWidth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownBlockWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBlockWidth.Name = "numericUpDownBlockWidth";
            this.numericUpDownBlockWidth.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownBlockWidth.TabIndex = 1;
            this.numericUpDownBlockWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownBlockWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownBlockWidth.ValueChanged += new System.EventHandler(this.numericUpDownBlockWidth_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 147);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alignment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(55, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 36);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(107, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 36);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 36);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(55, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 36);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(107, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 36);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(3, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 36);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(55, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 36);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(107, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 36);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonAlignment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "(Y)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "(Height)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "(X)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "(Width)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Offset:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonSave);
            this.tabPage4.Controls.Add(this.textBoxArrayName);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(623, 171);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Export Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(530, 119);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxArrayName
            // 
            this.textBoxArrayName.Location = new System.Drawing.Point(405, 34);
            this.textBoxArrayName.Name = "textBoxArrayName";
            this.textBoxArrayName.Size = new System.Drawing.Size(200, 22);
            this.textBoxArrayName.TabIndex = 2;
            this.textBoxArrayName.Text = "fnt_data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Array Name";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButtonColumn1);
            this.groupBox7.Controls.Add(this.radioButtonRow1);
            this.groupBox7.Location = new System.Drawing.Point(165, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(214, 125);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Scan Mode";
            // 
            // radioButtonColumn1
            // 
            this.radioButtonColumn1.AutoSize = true;
            this.radioButtonColumn1.Location = new System.Drawing.Point(6, 45);
            this.radioButtonColumn1.Name = "radioButtonColumn1";
            this.radioButtonColumn1.Size = new System.Drawing.Size(95, 18);
            this.radioButtonColumn1.TabIndex = 2;
            this.radioButtonColumn1.TabStop = true;
            this.radioButtonColumn1.Text = "Column Scan";
            this.radioButtonColumn1.UseVisualStyleBackColor = true;
            // 
            // radioButtonRow1
            // 
            this.radioButtonRow1.AutoSize = true;
            this.radioButtonRow1.Location = new System.Drawing.Point(6, 21);
            this.radioButtonRow1.Name = "radioButtonRow1";
            this.radioButtonRow1.Size = new System.Drawing.Size(79, 18);
            this.radioButtonRow1.TabIndex = 0;
            this.radioButtonRow1.TabStop = true;
            this.radioButtonRow1.Text = "Row Scan";
            this.radioButtonRow1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton11);
            this.groupBox6.Controls.Add(this.radioButton10);
            this.groupBox6.Controls.Add(this.radioButton9);
            this.groupBox6.Controls.Add(this.radioButton8);
            this.groupBox6.Location = new System.Drawing.Point(8, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(137, 125);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Color Mode";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 93);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(75, 18);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "RGB565p";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 69);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(68, 18);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "RGB565";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 45);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(79, 18);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "4bits Gray";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 21);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(55, 18);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Mono";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelCurrent);
            this.panel6.Controls.Add(this.pictureBoxZoom);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(631, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 20, 10, 3);
            this.panel6.Size = new System.Drawing.Size(188, 198);
            this.panel6.TabIndex = 0;
            // 
            // labelCurrent
            // 
            this.labelCurrent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCurrent.Location = new System.Drawing.Point(10, 175);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(168, 20);
            this.labelCurrent.TabIndex = 0;
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripSeparator1,
            this.toolStripButtonColorPicker,
            this.toolStripButtonFontViewer,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(819, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.Image = global::MosFontTool.Properties.Resources.complete;
            this.toolStripButtonView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(86, 52);
            this.toolStripButtonView.Text = "View";
            this.toolStripButtonView.Click += new System.EventHandler(this.toolStripButtonView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonColorPicker
            // 
            this.toolStripButtonColorPicker.Image = global::MosFontTool.Properties.Resources.colorPicker;
            this.toolStripButtonColorPicker.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonColorPicker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorPicker.Name = "toolStripButtonColorPicker";
            this.toolStripButtonColorPicker.Size = new System.Drawing.Size(122, 52);
            this.toolStripButtonColorPicker.Text = "Color Picker";
            this.toolStripButtonColorPicker.Click += new System.EventHandler(this.toolStripButtonColorPicker_Click);
            // 
            // toolStripButtonFontViewer
            // 
            this.toolStripButtonFontViewer.Image = global::MosFontTool.Properties.Resources.fontViewr;
            this.toolStripButtonFontViewer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFontViewer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFontViewer.Name = "toolStripButtonFontViewer";
            this.toolStripButtonFontViewer.Size = new System.Drawing.Size(126, 52);
            this.toolStripButtonFontViewer.Text = "Font Viewer";
            this.toolStripButtonFontViewer.Click += new System.EventHandler(this.toolStripButtonFontViewer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = global::MosFontTool.Properties.Resources.about;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(93, 52);
            this.toolStripButton4.Text = "About";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // richTextBoxCharInput
            // 
            this.richTextBoxCharInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCharInput.Location = new System.Drawing.Point(5, 5);
            this.richTextBoxCharInput.Name = "richTextBoxCharInput";
            this.richTextBoxCharInput.Size = new System.Drawing.Size(809, 93);
            this.richTextBoxCharInput.TabIndex = 1;
            this.richTextBoxCharInput.Text = "";
            // 
            // FormFontDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFontDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFontDraw";
            this.Resize += new System.EventHandler(this.FormFontDraw_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlockHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlockWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockWidth)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxSystemFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxBackgroundColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxForecolor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownOffsetY;
        private System.Windows.Forms.NumericUpDown numericUpDownOffsetX;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButtonRow1;
        private System.Windows.Forms.TextBox textBoxArrayName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Button buttonResetBlock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckBox checkBoxSortChars;
        private System.Windows.Forms.CheckBox checkBoxInsertNewLine;
        private System.Windows.Forms.CheckBox checkBoxIgnoreNewLine;
        private System.Windows.Forms.CheckBox checkBoxFilterChars;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.RadioButton radioButtonColumn1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorPicker;
        private System.Windows.Forms.ToolStripButton toolStripButtonFontViewer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TrackBar trackBarBlockWidth;
        private System.Windows.Forms.TrackBar trackBarOffsetY;
        private System.Windows.Forms.TrackBar trackBarOffsetX;
        private System.Windows.Forms.TrackBar trackBarBlockHeight;
        private System.Windows.Forms.RichTextBox richTextBoxCharInput;
    }
}