namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sehir;
            string Ad, Soyad, tc, doum;
            Ad = textBox2.Text;
            Soyad = textBox3.Text;
            tc = maskedTextBox1.Text;
            doum = maskedTextBox2.Text;
            listBox1.Text = "Adýnýz:" + Ad + "Soyadýnýz:" + Soyad + "Tcno:" + tc + "DoumTarihi" + doum;

            sehir = textBox1.Text;
            label1.Text = sehir;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ad, Soyad, tc, doum;
            Ad = textBox2.Text;
            Soyad = textBox3.Text;
            tc = maskedTextBox1.Text;
            doum = maskedTextBox2.Text;
            listBox1.Items.Add("Adýnýz:  "+Ad+" Soyadýnýz:  " + Soyad+ " Tc no:  " + tc+ " D.Tarihi:  " + doum);
        }
    }
}