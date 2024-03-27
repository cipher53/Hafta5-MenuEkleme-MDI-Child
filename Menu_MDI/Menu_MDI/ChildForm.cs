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
    public partial class ChildForm : Form
    {
        public ChildForm(string başlık, Color renk)
        {
            InitializeComponent();
            this.Text = başlık;
            this.BackColor = renk;

        }
    }
}
