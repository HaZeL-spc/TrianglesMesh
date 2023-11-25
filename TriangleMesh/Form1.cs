using System.Xml.Serialization;

namespace TriangleMesh
{
    public partial class Form1 : Form
    {
        public TriangleMesh triangleMesh;
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private double parameter = 0;
        private const double scalingFactor = 5;
        private const double angularVelocity = 0.1;

        public Form1()
        {
            InitializeComponent();

            drawArea = new DirectBitmap(Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea.Bitmap;
            using (Graphics g = Graphics.FromImage(drawArea.Bitmap))
            {
                g.Clear(Color.White);
            }

            triangleMesh = new TriangleMesh(drawArea, Canvas.Size.Width, Canvas.Size.Height);

            InitializeTimer();
        }

        private void InitializeTimer()
        {
            animationTimer.Interval = 5; // czas w milisekundach
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Oblicz nowe po³o¿enie s³oñca na spirali
            if (TriangleMesh.moveSun)
            {
				// Promieñ okrêgu
				double radius = 200;

				// Oblicz nowe po³o¿enie x i y na okrêgu
				double x = radius * Math.Cos(parameter);
				double y = radius * Math.Sin(parameter);


                // Przesuñ PictureBox do nowego po³o¿enia
                //TriangleMesh.SunCoords = new MyPoint3D((int)x + TriangleMesh.width / 2, (int)y + TriangleMesh.height / 2, TriangleMesh.sunZ);
                TriangleMesh.SunCoords = new MyPoint3D((int)x + TriangleMesh.width / 2, (int)y + TriangleMesh.height / 2, TriangleMesh.sunZ);
                //TriangleMesh.SunCoords = new MyPoint3D(TriangleMesh.SunCoords.X + 20, TriangleMesh.SunCoords.Y, TriangleMesh.sunZ);
                // Zwiêksz k¹t dla animacji ruchu po spirali
                parameter += angularVelocity;
                //MessageBox.Show($"{SunCoords.X}, {SunCoords.Y}, {SunCoords.Z}");
            }

            Canvas.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarTrianglesX_Scroll(object sender, EventArgs e)
        {
            int value = trackBarTrianglesX.Value;
            labelTrianglesXAxis.Text = "Triangles in X Axis: " + value.ToString();
            TriangleMesh.TRIANGLES_X = value;
            TriangleMesh.TRIANGLES_Y = value;
            triangleMesh.PrepareTriangles();

            Canvas.Refresh();
        }

        private void trackBarTrianglesY_Scroll(object sender, EventArgs e)
        {
            int value = trackBarTrianglesY.Value;
            labelTrianglesYAxis.Text = "Triangles in Y Axis: " + value.ToString();
            TriangleMesh.TRIANGLES_Y = value;
            triangleMesh.PrepareTriangles();

            Canvas.Refresh();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //drawArea.Refresh();
            Graphics g = e.Graphics;
            ScanlineFill scanline;

			// Parallel loop to process each triangle concurrently
			foreach (var triangle in TriangleMesh.triangles)
            {
                MyPoint3D[] points = { triangle.p1, triangle.p2, triangle.p3 };
                scanline = new ScanlineFill(points);

                scanline.FillPolygon();

                if (TriangleMesh.drawTriangulation)
                {
                    g.DrawLine(Pens.Black, new Point(points[0].X, points[0].Y), new Point(points[1].X, points[1].Y));
                    g.DrawLine(Pens.Black, new Point(points[1].X, points[1].Y), new Point(points[2].X, points[2].Y));
                    g.DrawLine(Pens.Black, new Point(points[1].X, points[1].Y), new Point(points[0].X, points[0].Y));
                }
            }

            // EXAMPLE OF DRAWING RANDOM POLYGON
            //MyPoint3D[] examplePolygon = {new MyPoint3D(200, 300, 0), new MyPoint3D(300, 340, 0),
            //            new MyPoint3D(200, 100, 0), new MyPoint3D(500, 100, 0),
            //            new MyPoint3D(350, 400, 0), new MyPoint3D(250, 500, 0), new MyPoint3D(200, 370, 0),
            //            new MyPoint3D(100, 470, 0), new MyPoint3D(50, 600, 0), new MyPoint3D(100, 400, 0)};

            //scanline = new ScanlineFill(examplePolygon);
            //scanline.FillPolygon(true);
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            int value = trackBarRed.Value;
            TriangleMesh.COLOUR_RED = value;
            PrepareChangeColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            int value = trackBarGreen.Value;
            TriangleMesh.COLOUR_GREEN = value;
            PrepareChangeColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            int value = trackBarBlue.Value;
            TriangleMesh.COLOUR_BLUE = value;
            PrepareChangeColor();
        }

        private void PrepareChangeColor(bool isSun = false)
        {
            if (isSun)
            {
                TriangleMesh.SunLight = Color.FromArgb(TriangleMesh.COLOUR_RED_SUN, TriangleMesh.COLOUR_GREEN_SUN, TriangleMesh.COLOUR_BLUE_SUN);
                labelSunColor.Text = $"Colour {(isSun ? "sun " : "")}rgb: ({TriangleMesh.COLOUR_RED_SUN},{TriangleMesh.COLOUR_GREEN_SUN},{TriangleMesh.COLOUR_BLUE_SUN})";
            }
            else
            {
                TriangleMesh.ColorRgb = Color.FromArgb(TriangleMesh.COLOUR_RED, TriangleMesh.COLOUR_GREEN, TriangleMesh.COLOUR_BLUE);
                labelColour.Text = $"Colour {(isSun ? "sun " : "")}rgb: ({TriangleMesh.COLOUR_RED},{TriangleMesh.COLOUR_GREEN},{TriangleMesh.COLOUR_BLUE})";
            }

            Canvas.Refresh();
        }

        private void textBoxRedSun_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRedSun.Text, out int value))
            {
                TriangleMesh.COLOUR_RED_SUN = value;
                PrepareChangeColor(true);
            }
        }

        private void textBoxGreenSun_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxGreenSun.Text, out int value))
            {
                TriangleMesh.COLOUR_GREEN_SUN = value;
                PrepareChangeColor(true);
            }
        }

        private void textBoxBlueSun_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxBlueSun.Text, out int value))
            {
                TriangleMesh.COLOUR_BLUE_SUN = value;
                PrepareChangeColor(true);
            }
        }

        private void trackBarM_Scroll(object sender, EventArgs e)
        {
            int value = trackBarM.Value;
            TriangleMesh.m = value;
            labelM.Text = $"m: {value}";

            Canvas.Refresh();
        }

        private void trackBarKD_Scroll(object sender, EventArgs e)
        {
            double value = trackBarKD.Value;
            TriangleMesh.Kd = value / 100;
            labelKD.Text = $"kd: {TriangleMesh.Kd}";

            Canvas.Refresh();
        }

        private void trackBarKS_Scroll(object sender, EventArgs e)
        {
            double value = trackBarKS.Value;
            TriangleMesh.Ks = value / 100;
            labelKS.Text = $"kd: {TriangleMesh.Ks}";

            Canvas.Refresh();
        }

        private void trackBarSunZ_Scroll(object sender, EventArgs e)
        {
            int value = trackBarSunZ.Value;
            TriangleMesh.sunZ = value;
            TriangleMesh.SunCoords.Z = value;
            labelSunZ.Text = $"Sun Z: {value}";

            Canvas.Refresh();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string textBoxName = textBox.Name;
                int i = int.Parse(textBoxName[7].ToString());
                int j = int.Parse(textBoxName[8].ToString());

                if (int.TryParse(textBox.Text, out int value))
                {
                    TriangleMesh.ControlPoints[i, j].Z = value;
                }
            }
            triangleMesh.PrepareTriangles();
            Canvas.Refresh();
        }

        private void checkBoxTriangulation_CheckedChanged(object sender, EventArgs e)
        {
            TriangleMesh.drawTriangulation = checkBoxTriangulation.Checked;
        }

        private void checkBoxMoveSun_CheckedChanged(object sender, EventArgs e)
        {
            TriangleMesh.moveSun = checkBoxMoveSun.Checked;
        }
    }
}