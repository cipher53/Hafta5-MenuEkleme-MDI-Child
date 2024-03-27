using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Yeni menü öğesine tıklandığında gerçekleşecek olay.
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her hakkı saklıdır \nYazar: Fatih Genç");
        }

         // Çıkış menü öğesine tıklandığında uygulamayı kapatır.
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Kırmızı renk menü öğesine tıklandığında gerçekleşecek olay.
        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
            kırmızıToolStripMenuItem.Checked = true;
            label1.ForeColor = Color.Red;
        }


         // Yeşil renk menü öğesine tıklandığında gerçekleşecek olay.
        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
            yeşilToolStripMenuItem.Checked = true;
            label1.ForeColor = Color.Green;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
            maviToolStripMenuItem.Checked = true;
            label1.ForeColor = Color.Blue;
        }

         // Tüm renk seçimlerini temizleyen metot.
        public void Temizle() {
            kırmızıToolStripMenuItem.Checked = false;
            yeşilToolStripMenuItem.Checked = false;
            maviToolStripMenuItem.Checked = false;
        }

        // Kalın veya italik font stilleri menü öğesine tıklandığında gerçekleşecek olay.
        private void fontstili_Klik(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = sender as ToolStripMenuItem;

            // Hangi font stiline tıklanıldığına bağlı olarak etiketin font stili ayarlanır.
            if (ts.Name == "kalınToolStripMenuItem")
            {
                label1.Font = new Font(label1.Font, FontStyle.Bold);
            } else if (ts.Name == "italikToolStripMenuItem") {
                label1.Font = new Font(label1.Font, FontStyle.Italic);
            }
        }
    }
}
