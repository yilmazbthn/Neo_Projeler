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
    public partial class Sekreter_Detay : Form
    {
        public Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Sekreter_Detay_Load(object sender, EventArgs e)
        {
            txttc.Text = tcno;
            //Ad Soyad      
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txttc.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read()) 
            {
                txtadsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //branşları datagrid e aktarma
            DataTable dt1= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Brans",bgl.baglanti());
            da.Fill(dt1);
            dataGridView3.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2= new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' '+DoktorSoyad)as'Doktorlarımız',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;
            //Branşı Comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            

        }

        private void btnkydt_Click(object sender, EventArgs e)
        {
            SqlCommand rnv = new SqlCommand("insert into Tbl_randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)", bgl.baglanti());
            rnv.Parameters.AddWithValue("@r1", msktarih.Text);
            rnv.Parameters.AddWithValue("@r2", msksaat.Text);
            rnv.Parameters.AddWithValue("@r3", cbbrans.Text);
            rnv.Parameters.AddWithValue("@r4", cbdoktor.Text);
            rnv.Parameters.AddWithValue("@r5", msktc.Text);
            rnv.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Başarıyla Oluşturulmuştur");

        }

        private void cbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbbrans.Text);
            SqlDataReader rnv = komut.ExecuteReader();
            while (rnv.Read()) 
            {
                cbdoktor.Items.Add(rnv[0] + " " + rnv[1]);
               
            }
            bgl.baglanti().Close();
        }

        private void btndyrolstr_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void doktorPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoktoHız drpn = new FrmDoktoHız();
            drpn.Show();
        }

        private void randevuListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrandevuliste frl=new frmrandevuliste();
            frl.Show();
        }
    }
}
