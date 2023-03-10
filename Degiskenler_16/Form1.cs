namespace Degiskenler_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ortalama;
            s1 = 25;
            s2 = 75;
            s3 = 90;
            ortalama = (s1 + s2 + s3) / 3;
            label1.Text = ortalama.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double sayi= Convert.ToDouble(textBox1.Text);
            label2.Text = sayi.ToString();
        }
    }
}