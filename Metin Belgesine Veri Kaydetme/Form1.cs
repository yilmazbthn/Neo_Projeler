﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin_Belgesine_Veri_Kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Metin Dosyaları|*.txt";
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet=new StreamWriter(saveFileDialog1.FileName);
           kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Kaydetme İşlemi Başarılı.");

        }
    }
}
