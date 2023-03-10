namespace Arac_kullanımları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Batuhan";
            label3.Text = "Batuhan";
            label4.Text = "Batuhan";
            label5.Text = "Batuhan";
            label6.Text = "Batuhan";
            label7.Text = "Batuhan";
            label8.Text = "Batuhan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label13.Text = textBox2.Text;
            label14.Text = textBox3.Text;
            label15.Text = textBox4.Text;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1 + " " + maskedTextBox2 + " " + maskedTextBox3);
        }
    }
}