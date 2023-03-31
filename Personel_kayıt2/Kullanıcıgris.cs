using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_kayıt2
{
    public partial class Kullanıcıgris : Form
    {
        public Kullanıcıgris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = BATUHAN; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            panel2.BackColor = Color.FromArgb(38, 38, 38, 70);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
            panel3.BackColor = Color.FromArgb(0, 8, 53);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 8, 53);
        }

        private void giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_giris where kullanici_mail=@p1 and sifre=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read() ) 
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı ya da Şifre");
            }
            baglanti.Close();
        }
    }
}
