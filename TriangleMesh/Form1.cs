namespace TriangleMesh
{
    public partial class Form1 : Form
    {
        public TriangleMesh triangleMesh;

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

            Canvas.Invalidate();
        }

        private void trackBarTrianglesY_Scroll(object sender, EventArgs e)
        {
            int value = trackBarTrianglesY.Value;
            labelTrianglesYAxis.Text = "Triangles in Y Axis: " + value.ToString();
            TriangleMesh.TRIANGLES_Y = value;
            triangleMesh.PrepareTriangles();

            Canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            drawArea.Refresh();

            triangleMesh.Paint();

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

        private void PrepareChangeColor()
        {
            labelColour.Text = $"Colour rgb: ({TriangleMesh.COLOUR_RED},{TriangleMesh.COLOUR_GREEN},{TriangleMesh.COLOUR_BLUE})";
            TriangleMesh.ColorRgb = Color.FromArgb(TriangleMesh.COLOUR_RED, TriangleMesh.COLOUR_GREEN, TriangleMesh.COLOUR_BLUE);

            Canvas.Invalidate();
        }
    }
}