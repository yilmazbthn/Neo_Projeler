namespace Switch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim=textBox1.Text;
            switch(mevsim)
            {
                case "yaz":label2.Text = "haziran,temmuz,a�ustos";break;
                case "sonbahar":label2.Text="Eyl�l,Ekim,Kas�m";break;
                case "K��":label2.Text="Aral�k,Ocak,�ubat";break;
                case "�lkbahar":label2.Text = "Mart,Nisan,May�s";break;
            }
        }
    }
}