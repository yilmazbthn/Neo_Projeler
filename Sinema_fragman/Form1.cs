namespace Sinema_fragman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webView21_Click(object sender, EventArgs e)
        {


        }

        private void bilimKurguToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jhonWickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("John Wick 3");
            webView21.Source = new Uri("https://www.beyazperde.com/filmler/film-250861/fragman-19552718/");
        }

        private void bendenÖnceSenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("Senden Önce Ben");
            webView21.Source = new Uri("https://www.beyazperde.com/filmler/film-230327/");
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("Cars");
            webView21.Source = new Uri("https://www.beyazperde.com/filmler/film-55774/fragman-18630839/");

        }

        private void behzatÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("Behzat Ç");
            webView21.Source = new Uri("https://www.beyazperde.com/diziler/dizi-9729/");
        }

        private void hakkýmýzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Batuhan Yýlmaz Tarafýndan yapýlmýþtýr.");
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void kýrmýzýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ("JOHN WÝCK 3");
        }
    }
}