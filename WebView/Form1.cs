using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace ViewWeb
{
    public partial class Form1 : Form
    {
        // İdarəetməni qurur və sosial media işarələrini əlavə edir.
        public Form1()
        {
            InitializeComponent();

            instagramToolStripMenuItem.Image = MakeIcon(Color.DeepPink, "I");
            youtubeToolStripMenuItem.Image = MakeIcon(Color.Red, "▶");
            facebookToolStripMenuItem.Image = MakeIcon(Color.RoyalBlue, "f");
            telegramToolStripMenuItem.Image = MakeIcon(Color.DeepSkyBlue, "➤");
        }

        // İkonları düzbucaqlı fonda dairə şəklində çəkir.
        private Image MakeIcon(Color color, string symbol)
        {
            Bitmap bitmap = new Bitmap(20, 20);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            graphics.FillEllipse(new SolidBrush(color), 0, 0, 20, 20);

            Font font = new Font("Segoe UI", 9, FontStyle.Bold);
            Brush textBrush = Brushes.White;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            graphics.DrawString(symbol, font, textBrush, new RectangleF(0, 0, 20, 20), format);

            format.Dispose();
            font.Dispose();
            graphics.Dispose();
            return bitmap;
        }

        // Proqram açıldıqda Google səhifəsini göstərir.
        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.az");
        }

        // Instagram səhifəsini açır.
        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com");
        }

        // Youtube səhifəsini açır.
        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com");
        }

        // Facebook səhifəsini açır.
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.facebook.com");
        }

        // Telegram səhifəsini açır.
        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.telegram.org");
        }

        // Menunun arxa rəngini dəyişir.
        private void arxaRengiDeyisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = dialog.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.DropDown.BackColor = dialog.Color;
                }
            }
        }

        // Menunun yazı rəngini dəyişir.
        private void yaziRengiDeyisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.ForeColor = dialog.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.DropDown.ForeColor = dialog.Color;
                }
            }
        }

        // Səhifəni böyüdür.
        private void boyutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.ZoomFactor < 4.9)
            {
                webView21.ZoomFactor += 0.1;
            }
        }

        // Səhifəni kiçildir.
        private void kiciltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.ZoomFactor > 0.2)
            {
                webView21.ZoomFactor -= 0.1;
            }
        }

        // Səhifəni çap edir.
        private void capEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.ShowPrintUI(CoreWebView2PrintDialogKind.Browser);
            }
        }

        // Tətbiqdən çıxış üçün təsdiq soruşur.
        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıxış edilsinmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Haqqında məlumatını göstərir.
        private void haqqindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ViewWeb Brauzer Tətbiqi", "Əlaqə");
        }
    }
}
