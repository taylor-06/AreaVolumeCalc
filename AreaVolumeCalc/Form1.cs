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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            width = double.Parse(textBox1.Text);
            label1.Text = "Area = " + rectangle.Area(width, height);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            height = double.Parse(textBox2.Text);
            label1.Text = "Area = " + rectangle.Area(width, height);
        }
    }
}