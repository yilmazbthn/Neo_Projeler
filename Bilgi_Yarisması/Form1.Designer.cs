namespace Bilgi_Yarisması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnA = new Button();
            btnB = new Button();
            btnD = new Button();
            btnC = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblsoruno = new Label();
            label3 = new Label();
            lbldogru = new Label();
            label5 = new Label();
            lblyanlıs = new Label();
            Btnsonraki = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnA
            // 
            btnA.Location = new Point(12, 214);
            btnA.Name = "btnA";
            btnA.Size = new Size(230, 61);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(269, 214);
            btnB.Name = "btnB";
            btnB.Size = new Size(230, 61);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(269, 281);
            btnD.Name = "btnD";
            btnD.Size = new Size(230, 61);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(12, 281);
            btnC.Name = "btnC";
            btnC.Size = new Size(230, 61);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(525, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(643, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(561, 39);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Soru No:";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Location = new Point(643, 39);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(13, 15);
            lblsoruno.TabIndex = 8;
            lblsoruno.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Doğru:";
            // 
            // lbldogru
            // 
            lbldogru.AutoSize = true;
            lbldogru.Location = new Point(643, 83);
            lbldogru.Name = "lbldogru";
            lbldogru.Size = new Size(13, 15);
            lbldogru.TabIndex = 10;
            lbldogru.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 123);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Yanlış:";
            // 
            // lblyanlıs
            // 
            lblyanlıs.AutoSize = true;
            lblyanlıs.Location = new Point(643, 123);
            lblyanlıs.Name = "lblyanlıs";
            lblyanlıs.Size = new Size(13, 15);
            lblyanlıs.TabIndex = 12;
            lblyanlıs.Text = "0";
            // 
            // Btnsonraki
            // 
            Btnsonraki.Location = new Point(558, 158);
            Btnsonraki.Name = "Btnsonraki";
            Btnsonraki.Size = new Size(139, 38);
            Btnsonraki.TabIndex = 13;
            Btnsonraki.Text = "Sonraki";
            Btnsonraki.UseVisualStyleBackColor = true;
            Btnsonraki.Click += Btnsonraki_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(8, 18);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(491, 178);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "Bilgi Yarışmamıza Hoşgeldiniz<3!! \nBaşlamak için \"Sonraki\" butonuna basınız.\nBol Şans.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 383);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 383);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 423);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(Btnsonraki);
            Controls.Add(lblyanlıs);
            Controls.Add(label5);
            Controls.Add(lbldogru);
            Controls.Add(label3);
            Controls.Add(lblsoruno);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblsoruno;
        private Label label3;
        private Label lbldogru;
        private Label label5;
        private Label lblyanlıs;
        private Button Btnsonraki;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label4;
    }
}