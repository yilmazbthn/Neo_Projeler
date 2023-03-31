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

namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        sqlbaglantisi bgl= new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * From tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorPanel frS = new FrmDoktorPanel();
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
