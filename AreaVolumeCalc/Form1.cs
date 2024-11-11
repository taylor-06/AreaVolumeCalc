namespace AreaVolumeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rectangle rectangle = new Rectangle(3, 3);

            label1.Text = double.Parse(rectangle.Area());
        }
    }
}