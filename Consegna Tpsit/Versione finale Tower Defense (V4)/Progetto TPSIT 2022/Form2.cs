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
    public partial class Menù : Form
    {
        public Menù()
        {
            InitializeComponent();
        }

        private void Menù_Load(object sender, EventArgs e)
        {

        }

        private void resume_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
