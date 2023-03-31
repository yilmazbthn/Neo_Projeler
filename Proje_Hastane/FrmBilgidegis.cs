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
    public partial class FrmBilgidegis : Form
    {
        public FrmBilgidegis()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmBilgidegis_Load(object sender, EventArgs e)
        {
            Masktc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Masktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                cbcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", msktel.Text);
            komut1.Parameters.AddWithValue("@p4", Txtsifre.Text);
            komut1.Parameters.AddWithValue("@p5", cbcinsiyet.Text);
            komut1.Parameters.AddWithValue("@p6", Masktc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }
    }
}
 