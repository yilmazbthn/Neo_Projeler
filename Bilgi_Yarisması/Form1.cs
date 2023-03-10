namespace Bilgi_Yarisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void Btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            soruno++;
            lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1923";
                btnB.Text = "1907";
                btnC.Text = "1905";
                btnD.Text = "1903";
                label2.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Fenerbahçe Kaç Yılında kuruldu?";
                btnA.Text = "1900";
                btnB.Text = "1907";
                btnC.Text = "1909";
                btnD.Text = "1903";
                label2.Text = "1907";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Hangi il iç anadoluda bulunmaz?";
                btnA.Text = "Niğde";
                btnB.Text = "Nevşehir";
                btnC.Text = "Ankara";
                btnD.Text = "Mersin";
                label2.Text = "Mersin";
                Btnsonraki.Text = "Sonuçlar";


            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                Btnsonraki.Enabled = false;
                MessageBox.Show("dogru:" + dogru + "\n" + "Yanlış:" + yanlis + "\n");
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label4.Text = btnA.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label4.Text = btnB.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label4.Text = btnC.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label4.Text = btnD.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}