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
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            labelColour = new Label();
            trackBarRed = new TrackBar();
            labelTrianglesXAxis = new Label();
            trackBarTrianglesX = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
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
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(32, 207);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(130, 56);
            trackBarBlue.TabIndex = 5;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(32, 170);
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
            trackBarRed.Size = new Size(130, 56);
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
    }
}