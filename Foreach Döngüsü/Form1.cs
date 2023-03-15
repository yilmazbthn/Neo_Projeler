namespace Foreach_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Mehmet", "Batu", "Berat", "Kerem" };
            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int ort = 0;
            int[] sayilar = { 70, 65, 75, 90, 45, 90, 55 };
            foreach (int i in sayilar)
            {
                toplam = toplam + i;
                ort = toplam / sayilar.Length;
                listBox1.Items.Add(i);
            }
            label1.Text=toplam.ToString();
            label2.Text=ort.ToString();
        }
        
    }
}