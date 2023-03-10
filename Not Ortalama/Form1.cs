namespace Not_Ortalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, prj;
            double ortalama;
            ad= textBox1.Text;
            soyad= textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            prj= Convert.ToInt16(textBox5.Text);
            ortalama=(s1+s2+prj)/3;
            listBox1.Items.Add(ad + " " + soyad + " Ortalama" + ortalama);

        }
    }
}