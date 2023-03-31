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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("Select * From tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TCNO.Text);
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                Sekreter_Detay frS = new Sekreter_Detay();
                frS.tcno = TCNO.Text;
                frS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC Yada Şifre");
                bgl.baglanti().Close();
            }
        }
    }
}
