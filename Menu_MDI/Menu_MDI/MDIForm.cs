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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        // Mavi renkli bir çocuk form oluşturan metot.
        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yeni bir çocuk form oluşturuluyor ve gösteriliyor.
            ChildForm child = new ChildForm("mavi form", Color.Blue);
            child.MdiParent = this;
            child.Show();
        }

        // Kırmızı renkli bir çocuk form oluşturan metot.
        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yeni bir çocuk form oluşturuluyor ve gösteriliyor.
            ChildForm child = new ChildForm("kırmızı form", Color.Red);
            child.MdiParent = this;
            child.Show();
        }

        // Yeşil renkli bir çocuk form oluşturan metot.
        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yeni bir çocuk form oluşturuluyor ve gösteriliyor.
            ChildForm child = new ChildForm("yeşil form", Color.Green);
            child.MdiParent = this;
            child.Show();
        }

        // Pencere düzenini kaskad şeklinde ayarlayan metot.
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // Pencere düzenini dikey olarak düzenleyen metot.
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // Pencere düzenini yatay olarak düzenleyen metot.
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Uygulamadan çıkış yapan metot.
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
