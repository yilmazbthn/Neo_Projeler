using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorPanel : Form
    {
        public string tcno;
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Batuhan Yılmaz Tarafından Yapılmıştır\n https://www.instagram.com/yilmazbthn/");
        }
    }
}
