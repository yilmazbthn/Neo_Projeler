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

namespace Personel_kayıt2
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = BATUHAN; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Personel_tbl", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read()) 
            {
                label2.Text = dr1[0].ToString();

            }
            baglanti.Close();
            //Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Personel_tbl where per_durum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Personel_tbl where per_durum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekar.Text = dr3[0].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select count(distinct (per_sehir)) From Personel_tbl", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehir.Text = dr4[0].ToString();

            }
            baglanti.Close();
            //Maal toplam
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(per_maas) From Personel_tbl", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltopmaas.Text = dr5[0].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select avg(per_maas) From Personel_tbl", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortmaas.Text = dr6[0].ToString();

            }
            baglanti.Close();
        }
    }
}
