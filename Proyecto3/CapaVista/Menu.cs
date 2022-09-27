using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos b = new Productos();
            b.MdiParent = this;
            b.Show();
        }
    }
}
