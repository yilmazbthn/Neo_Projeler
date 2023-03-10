namespace Sinema_fragman
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1 = new MenuStrip();
            kategorilerToolStripMenuItem = new ToolStripMenuItem();
            aksiyonToolStripMenuItem = new ToolStripMenuItem();
            jhonWickToolStripMenuItem = new ToolStripMenuItem();
            romantikToolStripMenuItem = new ToolStripMenuItem();
            bendenÖnceSenToolStripMenuItem = new ToolStripMenuItem();
            bilimKurguToolStripMenuItem = new ToolStripMenuItem();
            carsToolStripMenuItem = new ToolStripMenuItem();
            türkDiziToolStripMenuItem = new ToolStripMenuItem();
            behzatÇToolStripMenuItem = new ToolStripMenuItem();
            renklerToolStripMenuItem = new ToolStripMenuItem();
            maviToolStripMenuItem = new ToolStripMenuItem();
            kırmızıToolStripMenuItem = new ToolStripMenuItem();
            morToolStripMenuItem = new ToolStripMenuItem();
            hızlıErişimToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            resources.ApplyResources(webView21, "webView21");
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Name = "webView21";
            webView21.Source = new Uri("https://google.com", UriKind.Absolute);
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategorilerToolStripMenuItem, renklerToolStripMenuItem, hızlıErişimToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            resources.ApplyResources(kategorilerToolStripMenuItem, "kategorilerToolStripMenuItem");
            kategorilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aksiyonToolStripMenuItem, romantikToolStripMenuItem, bilimKurguToolStripMenuItem, türkDiziToolStripMenuItem });
            kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            // 
            // aksiyonToolStripMenuItem
            // 
            resources.ApplyResources(aksiyonToolStripMenuItem, "aksiyonToolStripMenuItem");
            aksiyonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jhonWickToolStripMenuItem });
            aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            // 
            // jhonWickToolStripMenuItem
            // 
            resources.ApplyResources(jhonWickToolStripMenuItem, "jhonWickToolStripMenuItem");
            jhonWickToolStripMenuItem.Name = "jhonWickToolStripMenuItem";
            jhonWickToolStripMenuItem.Click += jhonWickToolStripMenuItem_Click;
            // 
            // romantikToolStripMenuItem
            // 
            resources.ApplyResources(romantikToolStripMenuItem, "romantikToolStripMenuItem");
            romantikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bendenÖnceSenToolStripMenuItem });
            romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            // 
            // bendenÖnceSenToolStripMenuItem
            // 
            resources.ApplyResources(bendenÖnceSenToolStripMenuItem, "bendenÖnceSenToolStripMenuItem");
            bendenÖnceSenToolStripMenuItem.Name = "bendenÖnceSenToolStripMenuItem";
            bendenÖnceSenToolStripMenuItem.Click += bendenÖnceSenToolStripMenuItem_Click;
            // 
            // bilimKurguToolStripMenuItem
            // 
            resources.ApplyResources(bilimKurguToolStripMenuItem, "bilimKurguToolStripMenuItem");
            bilimKurguToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carsToolStripMenuItem });
            bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            bilimKurguToolStripMenuItem.Click += bilimKurguToolStripMenuItem_Click;
            // 
            // carsToolStripMenuItem
            // 
            resources.ApplyResources(carsToolStripMenuItem, "carsToolStripMenuItem");
            carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            carsToolStripMenuItem.Click += carsToolStripMenuItem_Click;
            // 
            // türkDiziToolStripMenuItem
            // 
            resources.ApplyResources(türkDiziToolStripMenuItem, "türkDiziToolStripMenuItem");
            türkDiziToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { behzatÇToolStripMenuItem });
            türkDiziToolStripMenuItem.Name = "türkDiziToolStripMenuItem";
            // 
            // behzatÇToolStripMenuItem
            // 
            resources.ApplyResources(behzatÇToolStripMenuItem, "behzatÇToolStripMenuItem");
            behzatÇToolStripMenuItem.Name = "behzatÇToolStripMenuItem";
            behzatÇToolStripMenuItem.Click += behzatÇToolStripMenuItem_Click;
            // 
            // renklerToolStripMenuItem
            // 
            resources.ApplyResources(renklerToolStripMenuItem, "renklerToolStripMenuItem");
            renklerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maviToolStripMenuItem, kırmızıToolStripMenuItem, morToolStripMenuItem });
            renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            // 
            // maviToolStripMenuItem
            // 
            resources.ApplyResources(maviToolStripMenuItem, "maviToolStripMenuItem");
            maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
            // 
            // kırmızıToolStripMenuItem
            // 
            resources.ApplyResources(kırmızıToolStripMenuItem, "kırmızıToolStripMenuItem");
            kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            kırmızıToolStripMenuItem.Click += kırmızıToolStripMenuItem_Click;
            // 
            // morToolStripMenuItem
            // 
            resources.ApplyResources(morToolStripMenuItem, "morToolStripMenuItem");
            morToolStripMenuItem.Name = "morToolStripMenuItem";
            morToolStripMenuItem.Click += morToolStripMenuItem_Click;
            // 
            // hızlıErişimToolStripMenuItem
            // 
            resources.ApplyResources(hızlıErişimToolStripMenuItem, "hızlıErişimToolStripMenuItem");
            hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            resources.ApplyResources(hakkımızdaToolStripMenuItem, "hakkımızdaToolStripMenuItem");
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            resources.ApplyResources(çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(webView21);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategorilerToolStripMenuItem;
        private ToolStripMenuItem aksiyonToolStripMenuItem;
        private ToolStripMenuItem jhonWickToolStripMenuItem;
        private ToolStripMenuItem romantikToolStripMenuItem;
        private ToolStripMenuItem bendenÖnceSenToolStripMenuItem;
        private ToolStripMenuItem bilimKurguToolStripMenuItem;
        private ToolStripMenuItem türkDiziToolStripMenuItem;
        private ToolStripMenuItem behzatÇToolStripMenuItem;
        private ToolStripMenuItem renklerToolStripMenuItem;
        private ToolStripMenuItem maviToolStripMenuItem;
        private ToolStripMenuItem kırmızıToolStripMenuItem;
        private ToolStripMenuItem morToolStripMenuItem;
        private ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem carsToolStripMenuItem;
        private Label label1;
    }
}