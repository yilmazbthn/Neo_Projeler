namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 54;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }
    }
}