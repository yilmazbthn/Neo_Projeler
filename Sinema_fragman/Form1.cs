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

        private void benden�nceSenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("Senden �nce Ben");
            webView21.Source = new Uri("https://www.beyazperde.com/filmler/film-230327/");
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("Cars");
            webView21.Source = new Uri("https://www.beyazperde.com/filmler/film-55774/fragman-18630839/");

        }

        private void behzat�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = ("Behzat �");
            webView21.Source = new Uri("https://www.beyazperde.com/diziler/dizi-9729/");
        }

        private void hakk�m�zdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Batuhan Y�lmaz Taraf�ndan yap�lm��t�r.");
        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void k�rm�z�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ("JOHN W�CK 3");
        }
    }
}