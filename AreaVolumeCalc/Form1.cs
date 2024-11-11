using System.Drawing;

namespace AreaVolumeCalc
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle();
        double width;
        double height;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalcArea_Click(object sender, EventArgs e)
        {
            width = double.Parse(areaWidthText.Text);
            height = double.Parse(areaHeightText.Text);

            if (shape2DSelector.Text == "Rectangle")
            {
                areaResult.Text = "Area = " + rectangle.Area(width, height);
            }
            else if (shape2DSelector.Text == "Ellipse")
            {
                areaResult.Text = "Function Unavailable";
            }
            else
            {
                areaResult.Text = "Function Unavailable";
            }
        }
    }
}