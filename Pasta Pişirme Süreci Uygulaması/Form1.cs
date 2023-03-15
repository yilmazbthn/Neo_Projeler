namespace Pasta_Pişirme_Süreci_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.White;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label1.Text = ("Un ve Yumurta Karıştırıldı(✓)");
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.White;
            }
            if (progressBar2.Value % 20 == 0)
            {
                label2.BackColor = Color.Red;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label2.Text = ("Çırpma İşlemi Tamamlandı(✓)");
                timer3.Start();
            }
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label3.Text = ("Malzemeler Eklendi Ve Karıştırıldı(✓)");
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 1;
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.White;
            }
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.Red;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                label4.Text = ("Pastanız Pişti(✓)");
                MessageBox.Show("Pastanız Hazır");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}