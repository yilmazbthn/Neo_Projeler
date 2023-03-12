namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 20)
            {

                this.BackColor = Color.Green;

            }
            if (sayac == 30)
            {

                this.BackColor = Color.Blue;

            }
            if (sayac == 40)
            {

                this.BackColor = Color.Yellow;

            }
            if (sayac == 50)
            {

                this.BackColor = Color.Red;
                timer1.Stop();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        int saat = 00, dakika = 00, saniye = 00;
        private void timer2_Tick(object sender, EventArgs e)
        {

            saniye++;
            label4.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label3.Text = dakika.ToString();
                saniye = 00;
            }
            if (dakika == 60)
            {
                saat++;
                label2.Text = saat.ToString();
                dakika = 00;
            }
            if (saat == 24)
            {
                dakika = 00;
                saniye = 00;
                saat = 0;
                timer2.Stop();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}