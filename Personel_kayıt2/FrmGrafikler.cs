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
using System.Threading;

namespace Personel_kayıt2
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = BATUHAN; Initial Catalog = PersonelVeriTabani; Integrated Security = True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg=new SqlCommand("Select Per_sehir,Count(*) from personel_tbl Group By per_sehir",baglanti);
            SqlDataReader rd1 = komutg.ExecuteReader();
            while (rd1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(rd1[0], rd1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutm = new SqlCommand("Select per_meslek,Avg(per_maas) from personel_tbl Group By per_meslek",baglanti);
            SqlDataReader rd2 = komutm.ExecuteReader();
            while (rd2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(rd2[0], rd2[1]);
            }
            baglanti.Close();


        }
    }
}
