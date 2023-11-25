namespace TriangleMesh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            Canvas = new PictureBox();
            checkBoxTriangulation = new CheckBox();
            textBox33 = new TextBox();
            textBox23 = new TextBox();
            textBox13 = new TextBox();
            textBox03 = new TextBox();
            textBox32 = new TextBox();
            textBox22 = new TextBox();
            textBox12 = new TextBox();
            textBox02 = new TextBox();
            textBox31 = new TextBox();
            textBox21 = new TextBox();
            textBox11 = new TextBox();
            textBox01 = new TextBox();
            textBox30 = new TextBox();
            textBox20 = new TextBox();
            textBox10 = new TextBox();
            textBox00 = new TextBox();
            labelSunZ = new Label();
            trackBarSunZ = new TrackBar();
            labelKS = new Label();
            trackBarKS = new TrackBar();
            labelKD = new Label();
            trackBarKD = new TrackBar();
            labelM = new Label();
            trackBarM = new TrackBar();
            textBoxBlueSun = new TextBox();
            textBoxGreenSun = new TextBox();
            textBoxRedSun = new TextBox();
            labelSunColor = new Label();
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            labelColour = new Label();
            trackBarRed = new TrackBar();
            labelTrianglesXAxis = new Label();
            trackBarTrianglesX = new TrackBar();
            checkBoxMoveSun = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrianglesX).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Right;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(-2, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(Canvas);
            splitContainer.Panel1.ForeColor = SystemColors.ControlText;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.ControlLight;
            splitContainer.Panel2.Controls.Add(checkBoxMoveSun);
            splitContainer.Panel2.Controls.Add(checkBoxTriangulation);
            splitContainer.Panel2.Controls.Add(textBox33);
            splitContainer.Panel2.Controls.Add(textBox23);
            splitContainer.Panel2.Controls.Add(textBox13);
            splitContainer.Panel2.Controls.Add(textBox03);
            splitContainer.Panel2.Controls.Add(textBox32);
            splitContainer.Panel2.Controls.Add(textBox22);
            splitContainer.Panel2.Controls.Add(textBox12);
            splitContainer.Panel2.Controls.Add(textBox02);
            splitContainer.Panel2.Controls.Add(textBox31);
            splitContainer.Panel2.Controls.Add(textBox21);
            splitContainer.Panel2.Controls.Add(textBox11);
            splitContainer.Panel2.Controls.Add(textBox01);
            splitContainer.Panel2.Controls.Add(textBox30);
            splitContainer.Panel2.Controls.Add(textBox20);
            splitContainer.Panel2.Controls.Add(textBox10);
            splitContainer.Panel2.Controls.Add(textBox00);
            splitContainer.Panel2.Controls.Add(labelSunZ);
            splitContainer.Panel2.Controls.Add(trackBarSunZ);
            splitContainer.Panel2.Controls.Add(labelKS);
            splitContainer.Panel2.Controls.Add(trackBarKS);
            splitContainer.Panel2.Controls.Add(labelKD);
            splitContainer.Panel2.Controls.Add(trackBarKD);
            splitContainer.Panel2.Controls.Add(labelM);
            splitContainer.Panel2.Controls.Add(trackBarM);
            splitContainer.Panel2.Controls.Add(textBoxBlueSun);
            splitContainer.Panel2.Controls.Add(textBoxGreenSun);
            splitContainer.Panel2.Controls.Add(textBoxRedSun);
            splitContainer.Panel2.Controls.Add(labelSunColor);
            splitContainer.Panel2.Controls.Add(trackBarBlue);
            splitContainer.Panel2.Controls.Add(trackBarGreen);
            splitContainer.Panel2.Controls.Add(labelColour);
            splitContainer.Panel2.Controls.Add(trackBarRed);
            splitContainer.Panel2.Controls.Add(labelTrianglesXAxis);
            splitContainer.Panel2.Controls.Add(trackBarTrianglesX);
            splitContainer.Size = new Size(1004, 705);
            splitContainer.SplitterDistance = 769;
            splitContainer.TabIndex = 0;
            // 
            // Canvas
            // 
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(769, 705);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.Click += Canvas_Click;
            Canvas.Paint += Canvas_Paint;
            // 
            // checkBoxTriangulation
            // 
            checkBoxTriangulation.AutoSize = true;
            checkBoxTriangulation.Checked = true;
            checkBoxTriangulation.CheckState = CheckState.Checked;
            checkBoxTriangulation.Location = new Point(39, 650);
            checkBoxTriangulation.Name = "checkBoxTriangulation";
            checkBoxTriangulation.Size = new Size(153, 24);
            checkBoxTriangulation.TabIndex = 34;
            checkBoxTriangulation.Text = "draw triangulation";
            checkBoxTriangulation.UseVisualStyleBackColor = true;
            checkBoxTriangulation.CheckedChanged += checkBoxTriangulation_CheckedChanged;
            // 
            // textBox33
            // 
            textBox33.Location = new Point(166, 590);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(36, 27);
            textBox33.TabIndex = 33;
            textBox33.Text = "0";
            textBox33.TextChanged += textBox_TextChanged;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(166, 557);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(36, 27);
            textBox23.TabIndex = 32;
            textBox23.Text = "0";
            textBox23.TextChanged += textBox_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(166, 524);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(36, 27);
            textBox13.TabIndex = 31;
            textBox13.Text = "0";
            textBox13.TextChanged += textBox_TextChanged;
            // 
            // textBox03
            // 
            textBox03.Location = new Point(166, 491);
            textBox03.Name = "textBox03";
            textBox03.Size = new Size(36, 27);
            textBox03.TabIndex = 30;
            textBox03.Text = "0";
            textBox03.TextChanged += textBox_TextChanged;
            // 
            // textBox32
            // 
            textBox32.Location = new Point(124, 590);
            textBox32.Name = "textBox32";
            textBox32.Size = new Size(36, 27);
            textBox32.TabIndex = 29;
            textBox32.Text = "0";
            textBox32.TextChanged += textBox_TextChanged;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(124, 557);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(36, 27);
            textBox22.TabIndex = 28;
            textBox22.Text = "0";
            textBox22.TextChanged += textBox_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(124, 524);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(36, 27);
            textBox12.TabIndex = 27;
            textBox12.Text = "0";
            textBox12.TextChanged += textBox_TextChanged;
            // 
            // textBox02
            // 
            textBox02.Location = new Point(124, 491);
            textBox02.Name = "textBox02";
            textBox02.Size = new Size(36, 27);
            textBox02.TabIndex = 26;
            textBox02.Text = "0";
            textBox02.TextChanged += textBox_TextChanged;
            // 
            // textBox31
            // 
            textBox31.Location = new Point(82, 590);
            textBox31.Name = "textBox31";
            textBox31.Size = new Size(36, 27);
            textBox31.TabIndex = 25;
            textBox31.Text = "0";
            textBox31.TextChanged += textBox_TextChanged;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(82, 557);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(36, 27);
            textBox21.TabIndex = 24;
            textBox21.Text = "0";
            textBox21.TextChanged += textBox_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(82, 524);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(36, 27);
            textBox11.TabIndex = 23;
            textBox11.Text = "0";
            textBox11.TextChanged += textBox_TextChanged;
            // 
            // textBox01
            // 
            textBox01.Location = new Point(82, 491);
            textBox01.Name = "textBox01";
            textBox01.Size = new Size(36, 27);
            textBox01.TabIndex = 22;
            textBox01.Text = "0";
            textBox01.TextChanged += textBox_TextChanged;
            // 
            // textBox30
            // 
            textBox30.Location = new Point(40, 590);
            textBox30.Name = "textBox30";
            textBox30.Size = new Size(36, 27);
            textBox30.TabIndex = 21;
            textBox30.Text = "0";
            textBox30.TextChanged += textBox_TextChanged;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(40, 557);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(36, 27);
            textBox20.TabIndex = 20;
            textBox20.Text = "0";
            textBox20.TextChanged += textBox_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(39, 524);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(36, 27);
            textBox10.TabIndex = 19;
            textBox10.Text = "0";
            textBox10.TextChanged += textBox_TextChanged;
            // 
            // textBox00
            // 
            textBox00.Location = new Point(40, 491);
            textBox00.Name = "textBox00";
            textBox00.Size = new Size(36, 27);
            textBox00.TabIndex = 18;
            textBox00.Text = "0";
            textBox00.TextChanged += textBox_TextChanged;
            // 
            // labelSunZ
            // 
            labelSunZ.AutoSize = true;
            labelSunZ.Location = new Point(118, 397);
            labelSunZ.Name = "labelSunZ";
            labelSunZ.Size = new Size(69, 20);
            labelSunZ.TabIndex = 17;
            labelSunZ.Text = "Sun Z: 40";
            // 
            // trackBarSunZ
            // 
            trackBarSunZ.Location = new Point(112, 418);
            trackBarSunZ.Maximum = 80;
            trackBarSunZ.Minimum = 20;
            trackBarSunZ.Name = "trackBarSunZ";
            trackBarSunZ.Size = new Size(69, 56);
            trackBarSunZ.TabIndex = 16;
            trackBarSunZ.Value = 40;
            trackBarSunZ.Scroll += trackBarSunZ_Scroll;
            // 
            // labelKS
            // 
            labelKS.AutoSize = true;
            labelKS.Location = new Point(39, 397);
            labelKS.Name = "labelKS";
            labelKS.Size = new Size(37, 20);
            labelKS.TabIndex = 15;
            labelKS.Text = "ks: 1";
            // 
            // trackBarKS
            // 
            trackBarKS.Location = new Point(32, 418);
            trackBarKS.Maximum = 100;
            trackBarKS.Name = "trackBarKS";
            trackBarKS.Size = new Size(80, 56);
            trackBarKS.TabIndex = 14;
            trackBarKS.Value = 100;
            trackBarKS.Scroll += trackBarKS_Scroll;
            // 
            // labelKD
            // 
            labelKD.AutoSize = true;
            labelKD.Location = new Point(112, 331);
            labelKD.Name = "labelKD";
            labelKD.Size = new Size(40, 20);
            labelKD.TabIndex = 13;
            labelKD.Text = "kd: 1";
            // 
            // trackBarKD
            // 
            trackBarKD.Location = new Point(101, 356);
            trackBarKD.Maximum = 100;
            trackBarKD.Name = "trackBarKD";
            trackBarKD.Size = new Size(74, 56);
            trackBarKD.TabIndex = 12;
            trackBarKD.Value = 100;
            trackBarKD.Scroll += trackBarKD_Scroll;
            // 
            // labelM
            // 
            labelM.AutoSize = true;
            labelM.Location = new Point(35, 331);
            labelM.Name = "labelM";
            labelM.Size = new Size(37, 20);
            labelM.TabIndex = 11;
            labelM.Text = "m: 1";
            // 
            // trackBarM
            // 
            trackBarM.Location = new Point(32, 356);
            trackBarM.Maximum = 100;
            trackBarM.Minimum = 1;
            trackBarM.Name = "trackBarM";
            trackBarM.Size = new Size(80, 56);
            trackBarM.TabIndex = 10;
            trackBarM.Value = 1;
            trackBarM.Scroll += trackBarM_Scroll;
            // 
            // textBoxBlueSun
            // 
            textBoxBlueSun.Location = new Point(138, 293);
            textBoxBlueSun.Name = "textBoxBlueSun";
            textBoxBlueSun.Size = new Size(43, 27);
            textBoxBlueSun.TabIndex = 9;
            textBoxBlueSun.Text = "255";
            textBoxBlueSun.TextChanged += textBoxBlueSun_TextChanged;
            // 
            // textBoxGreenSun
            // 
            textBoxGreenSun.Location = new Point(87, 293);
            textBoxGreenSun.Name = "textBoxGreenSun";
            textBoxGreenSun.Size = new Size(45, 27);
            textBoxGreenSun.TabIndex = 8;
            textBoxGreenSun.Text = "255";
            textBoxGreenSun.TextChanged += textBoxGreenSun_TextChanged;
            // 
            // textBoxRedSun
            // 
            textBoxRedSun.Location = new Point(38, 293);
            textBoxRedSun.Name = "textBoxRedSun";
            textBoxRedSun.Size = new Size(43, 27);
            textBoxRedSun.TabIndex = 7;
            textBoxRedSun.Text = "255";
            textBoxRedSun.TextChanged += textBoxRedSun_TextChanged;
            // 
            // labelSunColor
            // 
            labelSunColor.AutoSize = true;
            labelSunColor.Location = new Point(15, 253);
            labelSunColor.Name = "labelSunColor";
            labelSunColor.Size = new Size(166, 20);
            labelSunColor.TabIndex = 6;
            labelSunColor.Text = "Sun color: (255,255,255)";
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(32, 203);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(130, 56);
            trackBarBlue.TabIndex = 5;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(32, 164);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(130, 56);
            trackBarGreen.TabIndex = 4;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // labelColour
            // 
            labelColour.AutoSize = true;
            labelColour.Location = new Point(40, 98);
            labelColour.Name = "labelColour";
            labelColour.Size = new Size(127, 20);
            labelColour.TabIndex = 3;
            labelColour.Text = "Colour rgb: (0,0,0)";
            labelColour.Click += label1_Click_1;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(32, 125);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(135, 56);
            trackBarRed.TabIndex = 2;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // labelTrianglesXAxis
            // 
            labelTrianglesXAxis.AutoSize = true;
            labelTrianglesXAxis.Location = new Point(32, 25);
            labelTrianglesXAxis.Name = "labelTrianglesXAxis";
            labelTrianglesXAxis.Size = new Size(143, 20);
            labelTrianglesXAxis.TabIndex = 1;
            labelTrianglesXAxis.Text = "Triangles in X Axis: 5";
            labelTrianglesXAxis.Click += label1_Click;
            // 
            // trackBarTrianglesX
            // 
            trackBarTrianglesX.Location = new Point(32, 48);
            trackBarTrianglesX.Maximum = 15;
            trackBarTrianglesX.Minimum = 5;
            trackBarTrianglesX.Name = "trackBarTrianglesX";
            trackBarTrianglesX.Size = new Size(130, 56);
            trackBarTrianglesX.TabIndex = 0;
            trackBarTrianglesX.Value = 5;
            trackBarTrianglesX.Scroll += trackBarTrianglesX_Scroll;
            // 
            // checkBoxMoveSun
            // 
            checkBoxMoveSun.AutoSize = true;
            checkBoxMoveSun.Checked = true;
            checkBoxMoveSun.CheckState = CheckState.Checked;
            checkBoxMoveSun.Location = new Point(39, 680);
            checkBoxMoveSun.Name = "checkBoxMoveSun";
            checkBoxMoveSun.Size = new Size(94, 24);
            checkBoxMoveSun.TabIndex = 35;
            checkBoxMoveSun.Text = "move sun";
            checkBoxMoveSun.UseVisualStyleBackColor = true;
            checkBoxMoveSun.CheckedChanged += checkBoxMoveSun_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 705);
            Controls.Add(splitContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKS).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKD).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarM).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrianglesX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label labelTrianglesXAxis;
        private TrackBar trackBarTrianglesX;
        private Label labelTrianglesYAxis;
        private TrackBar trackBarTrianglesY;
        private PictureBox Canvas;
        private DirectBitmap drawArea;
        private TrackBar trackBarRed;
        private Label labelColour;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Label labelSunColor;
        private TextBox textBoxBlueSun;
        private TextBox textBoxGreenSun;
        private TextBox textBoxRedSun;
        private Label labelM;
        private TrackBar trackBarM;
        private Label labelKD;
        private TrackBar trackBarKD;
        private Label labelKS;
        private TrackBar trackBarKS;
        private Label labelSunZ;
        private TrackBar trackBarSunZ;
        private TextBox textBox00;
        private TextBox textBox33;
        private TextBox textBox23;
        private TextBox textBox13;
        private TextBox textBox03;
        private TextBox textBox32;
        private TextBox textBox22;
        private TextBox textBox12;
        private TextBox textBox02;
        private TextBox textBox31;
        private TextBox textBox21;
        private TextBox textBox11;
        private TextBox textBox01;
        private TextBox textBox30;
        private TextBox textBox20;
        private TextBox textBox10;
        private CheckBox checkBoxTriangulation;
        private CheckBox checkBoxMoveSun;
    }
}