namespace Proje_Hastane
{
    partial class FrmBilgidegis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgidegis));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.btndegiss = new System.Windows.Forms.Button();
            this.Masktc = new System.Windows.Forms.MaskedTextBox();
            this.Txtsifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbcinsiyet);
            this.panel2.Controls.Add(this.msktel);
            this.panel2.Controls.Add(this.btndegiss);
            this.panel2.Controls.Add(this.Masktc);
            this.panel2.Controls.Add(this.Txtsifre);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TxtSoyad);
            this.panel2.Controls.Add(this.TxtAd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cbcinsiyet
            // 
            resources.ApplyResources(this.cbcinsiyet, "cbcinsiyet");
            this.cbcinsiyet.FormattingEnabled = true;
            this.cbcinsiyet.Items.AddRange(new object[] {
            resources.GetString("cbcinsiyet.Items"),
            resources.GetString("cbcinsiyet.Items1")});
            this.cbcinsiyet.Name = "cbcinsiyet";
            // 
            // msktel
            // 
            resources.ApplyResources(this.msktel, "msktel");
            this.msktel.Name = "msktel";
            // 
            // btndegiss
            // 
            resources.ApplyResources(this.btndegiss, "btndegiss");
            this.btndegiss.Name = "btndegiss";
            this.btndegiss.UseVisualStyleBackColor = true;
            this.btndegiss.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // Masktc
            // 
            resources.ApplyResources(this.Masktc, "Masktc");
            this.Masktc.Name = "Masktc";
            this.Masktc.ValidatingType = typeof(int);
            // 
            // Txtsifre
            // 
            resources.ApplyResources(this.Txtsifre, "Txtsifre");
            this.Txtsifre.Name = "Txtsifre";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // TxtSoyad
            // 
            resources.ApplyResources(this.TxtSoyad, "TxtSoyad");
            this.TxtSoyad.Name = "TxtSoyad";
            // 
            // TxtAd
            // 
            resources.ApplyResources(this.TxtAd, "TxtAd");
            this.TxtAd.Name = "TxtAd";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // FrmBilgidegis
            // 
            this.AcceptButton = this.btndegiss;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "FrmBilgidegis";
            this.Load += new System.EventHandler(this.FrmBilgidegis_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Button btndegiss;
        private System.Windows.Forms.MaskedTextBox Masktc;
        private System.Windows.Forms.TextBox Txtsifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}