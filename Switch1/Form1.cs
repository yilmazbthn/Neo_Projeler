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
                case "yaz":label2.Text = "haziran,temmuz,aðustos";break;
                case "sonbahar":label2.Text="Eylül,Ekim,Kasým";break;
                case "Kýþ":label2.Text="Aralýk,Ocak,Þubat";break;
                case "Ýlkbahar":label2.Text = "Mart,Nisan,Mayýs";break;
            }
        }
    }
}