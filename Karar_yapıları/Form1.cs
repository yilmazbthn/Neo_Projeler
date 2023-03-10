namespace Karar_yapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            ort = (s1 + s2 + s3) / 3;
            if (ort > 50)
            {
                durum = "Geçti";
            }
            else {
                durum = "Kaldı";
                    }
            textBox4.Text = ort.ToString("0.00") + "/" + durum;
        }
    }
}