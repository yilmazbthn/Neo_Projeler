using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            tabControl1.SelectedTab = tabPage2;
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,Hastatel,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", Msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktel.Text);
            komut.Parameters.AddWithValue("@p5", Txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Tamamlanmıştır");

            tabControl1.SelectedTab = tabPage1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1=new SqlCommand("Select * From tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read()) 
            {
                FrmHastaDetay fr=new FrmHastaDetay();
                fr.tc= textBox1.Text;
                fr.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı TC Yada Şifre");
                bgl.baglanti().Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
