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

namespace Proje_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            label6.Text = tc;
            //Ad Soyad Çekme
            SqlCommand cmd = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", label6.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label3.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();
            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_randevu where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_brans", bgl.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                cbbrans.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();
        }

            //Doktorları Çekme

        private void cbbrans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cbbrans.Text);
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cbdoktor.Items.Add(dr2[0] + " " + dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void cbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_randevu where RandevuBrans='" + cbbrans.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgidznle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgidegis fr=new FrmBilgidegis();
            fr.TCno = label6.Text;
            fr.Show();
        }
    }
}
