using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_TPSIT_2022
{
    public partial class SchermataIniziale : Form
    {
        public SchermataIniziale()
        {
            InitializeComponent();
        }

        private void Inizio_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Launch browser to facebook...
            System.Diagnostics.Process.Start("https://it.wikipedia.org/wiki/Tower_defense");
        }

        private void TastoValuta_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
