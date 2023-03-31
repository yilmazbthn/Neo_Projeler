 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Personel_kayıt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source = BATUHAN; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox4.Text = "";
            ad.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Personel_tbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel_tblTableAdapter.Fill(this.personelVeriTabaniDataSet.Personel_tbl);

        }

        private void listele_Click(object sender, EventArgs e)
        {
            this.personel_tblTableAdapter.Fill(this.personelVeriTabaniDataSet.Personel_tbl);
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into Personel_tbl (per_ad,per_soyad,per_sehir,per_maas,per_meslek,per_durum) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p5", textBox4.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);

            komut.ExecuteNonQuery();
            Temizle();
            MessageBox.Show("Personel Eklendi");

            baglanti.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {


                label1.Text = "true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {


                label1.Text = "false";
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From personel_tbl where per_id=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi!");

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

            if(label1.Text=="True")
            {
                radioButton1.Checked = true;

            }
             if (label1.Text=="False")
            { 
            
             
                radioButton2.Checked = true;
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle=new SqlCommand("Update Personel_tbl Set per_ad=@a1,per_soyad=@a2,per_sehir=@a3,per_maas=@a4,per_durum=@a5,per_meslek=@a6 where per_id=@a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a4", maskedTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label1.Text);
            komutguncelle.Parameters.AddWithValue("@a6", textBox4.Text);
            komutguncelle.Parameters.AddWithValue("@a7", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgisi Güncellendi");

            

        }

        private void istatistik_Click(object sender, EventArgs e)
        {
            frmistatistik fr=new frmistatistik();
            fr.Show();
        }

        private void grafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg=new FrmGrafikler();
            frg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanıcıgris frgg=new Kullanıcıgris();
            frgg.Show();
        }
    }
}
