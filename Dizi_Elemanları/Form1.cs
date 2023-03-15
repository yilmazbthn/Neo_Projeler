namespace Dizi_Elemanları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 11, 23, 22, 34, 43, 101, 104, 106, 108 };
            for (int i = 0; i < sayilar.Length; i++) 
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}