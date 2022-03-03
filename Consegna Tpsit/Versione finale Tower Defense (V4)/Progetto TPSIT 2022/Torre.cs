using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_TPSIT_2022
{
    public class Torre
    {

        public int PS { get; set; }
        public int ID { get; private set; }
        public PictureBox PicBox { get; private set; }
        public TextBox tb { get; }

        public ProgressBar pb { get; set; }

        public Torre(int p, int id, ProgressBar Prg, PictureBox pbx, TextBox text)
        { PS = p; ID = id; pb = Prg; PicBox = pbx; tb = text; }


    }
}