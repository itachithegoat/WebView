namespace ViewWeb
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Form bağlandıqda istifadə olunan mənbələri təmizləyir.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // İdarəetmə elementlərini yaradıb tənzimləyir.
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sosialMediaToolStripMenuItem = new ToolStripMenuItem();
            instagramToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            facebookToolStripMenuItem = new ToolStripMenuItem();
            telegramToolStripMenuItem = new ToolStripMenuItem();
            aletlerToolStripMenuItem = new ToolStripMenuItem();
            arxaRengiDeyisToolStripMenuItem = new ToolStripMenuItem();
            yaziRengiDeyisToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            boyutToolStripMenuItem = new ToolStripMenuItem();
            kiciltToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            capEtToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cixisToolStripMenuItem = new ToolStripMenuItem();
            elaqeToolStripMenuItem = new ToolStripMenuItem();
            haqqindaToolStripMenuItem = new ToolStripMenuItem();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();

            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(webView21)).BeginInit();
            SuspendLayout();

            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Orange;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[]
            {
                sosialMediaToolStripMenuItem,
                aletlerToolStripMenuItem,
                elaqeToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            sosialMediaToolStripMenuItem.Name = "sosialMediaToolStripMenuItem";
            sosialMediaToolStripMenuItem.Size = new Size(91, 23);
            sosialMediaToolStripMenuItem.Text = "Sosial media";
            sosialMediaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                instagramToolStripMenuItem,
                youtubeToolStripMenuItem,
                facebookToolStripMenuItem,
                telegramToolStripMenuItem
            });

            instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            instagramToolStripMenuItem.Size = new Size(180, 22);
            instagramToolStripMenuItem.Text = "İnstagram";
            instagramToolStripMenuItem.Click += instagramToolStripMenuItem_Click;

            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(180, 22);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;

            facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            facebookToolStripMenuItem.Size = new Size(180, 22);
            facebookToolStripMenuItem.Text = "Facebook";
            facebookToolStripMenuItem.Click += facebookToolStripMenuItem_Click;

            telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            telegramToolStripMenuItem.Size = new Size(180, 22);
            telegramToolStripMenuItem.Text = "Telegram";
            telegramToolStripMenuItem.Click += telegramToolStripMenuItem_Click;

            aletlerToolStripMenuItem.Name = "aletlerToolStripMenuItem";
            aletlerToolStripMenuItem.Size = new Size(65, 23);
            aletlerToolStripMenuItem.Text = "Alətlər";
            aletlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                arxaRengiDeyisToolStripMenuItem,
                yaziRengiDeyisToolStripMenuItem,
                toolStripSeparator1,
                boyutToolStripMenuItem,
                kiciltToolStripMenuItem,
                toolStripSeparator2,
                capEtToolStripMenuItem,
                toolStripSeparator3,
                cixisToolStripMenuItem
            });

            arxaRengiDeyisToolStripMenuItem.Name = "arxaRengiDeyisToolStripMenuItem";
            arxaRengiDeyisToolStripMenuItem.Size = new Size(180, 22);
            arxaRengiDeyisToolStripMenuItem.Text = "Arxa rəngi dəyiş";
            arxaRengiDeyisToolStripMenuItem.Click += arxaRengiDeyisToolStripMenuItem_Click;

            yaziRengiDeyisToolStripMenuItem.Name = "yaziRengiDeyisToolStripMenuItem";
            yaziRengiDeyisToolStripMenuItem.Size = new Size(180, 22);
            yaziRengiDeyisToolStripMenuItem.Text = "Yazı rəngi dəyiş";
            yaziRengiDeyisToolStripMenuItem.Click += yaziRengiDeyisToolStripMenuItem_Click;

            boyutToolStripMenuItem.Name = "boyutToolStripMenuItem";
            boyutToolStripMenuItem.Size = new Size(180, 22);
            boyutToolStripMenuItem.Text = "Böyüt (+)";
            boyutToolStripMenuItem.Click += boyutToolStripMenuItem_Click;

            kiciltToolStripMenuItem.Name = "kiciltToolStripMenuItem";
            kiciltToolStripMenuItem.Size = new Size(180, 22);
            kiciltToolStripMenuItem.Text = "Kiçilt (-)";
            kiciltToolStripMenuItem.Click += kiciltToolStripMenuItem_Click;

            capEtToolStripMenuItem.Name = "capEtToolStripMenuItem";
            capEtToolStripMenuItem.Size = new Size(180, 22);
            capEtToolStripMenuItem.Text = "Çap et";
            capEtToolStripMenuItem.Click += capEtToolStripMenuItem_Click;

            cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            cixisToolStripMenuItem.Size = new Size(180, 22);
            cixisToolStripMenuItem.Text = "Çıxış";
            cixisToolStripMenuItem.Click += cixisToolStripMenuItem_Click;

            elaqeToolStripMenuItem.Name = "elaqeToolStripMenuItem";
            elaqeToolStripMenuItem.Size = new Size(65, 23);
            elaqeToolStripMenuItem.Text = "Əlaqə";
            elaqeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                haqqindaToolStripMenuItem
            });

            haqqindaToolStripMenuItem.Name = "haqqindaToolStripMenuItem";
            haqqindaToolStripMenuItem.Size = new Size(180, 22);
            haqqindaToolStripMenuItem.Text = "Haqqında";
            haqqindaToolStripMenuItem.Click += haqqindaToolStripMenuItem_Click;

            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 27);
            webView21.Name = "webView21";
            webView21.Size = new Size(1008, 654);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            webView21.Dock = DockStyle.Fill;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(webView21);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewWeb - Web Browser";
            Load += Form1_Load;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(webView21)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sosialMediaToolStripMenuItem;
        private ToolStripMenuItem instagramToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripMenuItem facebookToolStripMenuItem;
        private ToolStripMenuItem telegramToolStripMenuItem;
        private ToolStripMenuItem aletlerToolStripMenuItem;
        private ToolStripMenuItem arxaRengiDeyisToolStripMenuItem;
        private ToolStripMenuItem yaziRengiDeyisToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem boyutToolStripMenuItem;
        private ToolStripMenuItem kiciltToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem capEtToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cixisToolStripMenuItem;
        private ToolStripMenuItem elaqeToolStripMenuItem;
        private ToolStripMenuItem haqqindaToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
