namespace Toplu_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2,toplam,carpım,bolüm,cıkarm;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam=sayi1 + sayi2;
            cıkarm=sayi1-sayi2;
            carpım = sayi1 * sayi2;
            bolüm=sayi1/sayi2;
            MessageBox.Show("toplam" + toplam + "   n" + "Fark" + cıkarm + "/n" + "Çarpım" + carpım + "/n" + "bölüm" + bolüm);
        }
    }
}