namespace Uçuş_rezerve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + " - " + comboBox2.Text + " Tarih:" + dateTimePicker1.Text + " Saat:" + maskedTextBox2.Text);
            listBox1.Items.Add("Yolcu Bilgileri:" + " Ad-Soyad:" + textBox1.Text + " TC No:" + maskedTextBox1.Text + " Telefon No:" + maskedTextBox3 );
        }
    }
}