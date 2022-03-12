using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolt
{
    public partial class Slideshow : Form
    {
        //keeps track of the current img
        private int img;

        public Slideshow()
        {
            InitializeComponent();
            img = 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //update the image every 2000 ms
            picMia.Image = img == 1 ?
                Properties.Resources.mia1 : img == 2 ?
                Properties.Resources.mia2 : img == 3 ?
                Properties.Resources.mia3 :
                Properties.Resources.mia4;
            //update img counter
            img = img < 4 ? img+1 : 1;
        }

        //initial img
        private void Slideshow_Load(object sender, EventArgs e)
        {
            picMia.Image = Properties.Resources.mia4;
        }
    }
}
