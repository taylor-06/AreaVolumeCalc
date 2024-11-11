using System.Drawing;

namespace AreaVolumeCalc
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle();
        Ellipse ellipse = new Ellipse();
        Triangle triangle = new Triangle();

        Cube cube = new Cube();
        Sphere sphere = new Sphere();
        Cylinder cylinder = new Cylinder();

        double width;
        double height;
        double radius;
        double depth;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalcArea_Click(object sender, EventArgs e)
        {
            width = double.Parse(widthText.Text);
            height = double.Parse(heightText.Text);
            radius = double.Parse(radiusText.Text);
            depth = double.Parse(depthText.Text);

            if (shape2DSelector.Text == "Rectangle")
            {
                areaResult.Text = "Area = " + rectangle.Area(width, height, radius);
            }
            else if (shape2DSelector.Text == "Ellipse")
            {
                areaResult.Text = "Area = " + ellipse.Area(width, height, radius);
            }
            else if (shape2DSelector.Text == "Triangle")
            {
                areaResult.Text = "Area = " + triangle.Area(width, height, radius);
            }
            else
            {
                areaResult.Text = "Error";
            }
        }

        private void btn_CalcVolume_Click(object sender, EventArgs e)
        {
            width = double.Parse(widthText.Text);
            height = double.Parse(heightText.Text);
            radius = double.Parse(radiusText.Text);
            depth = double.Parse(depthText.Text);

            if (shape3DSelector.Text == "Cube")
            {
                volumeResult.Text = "Volume = " + cube.Volume(width, height, radius, depth);
            }
            else if (shape3DSelector.Text == "Sphere")
            {
                volumeResult.Text = "Volume = " + sphere.Volume(width, height, radius, depth);
            }
            else if (shape3DSelector.Text == "Cylinder")
            {
                volumeResult.Text = "Volume = " + cylinder.Volume(width, height, radius, depth);
            }
            else
            {
                volumeResult.Text = "Error";
            }
        }
    }
}