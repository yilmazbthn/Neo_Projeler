namespace İnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2,toplam;
            sayi1 = 24;
            sayi2 = 23;
            toplam=sayi1 + sayi2;
            label1.Text = toplam.ToString();
        }
    }
}