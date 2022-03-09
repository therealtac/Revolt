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
    public partial class ManageRevoltists : ViewRevoltists
    {
        public ManageRevoltists() : base()
        {
            InitializeComponent();
        }

        private void addRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addRemoveRevoltist = new AddRemoveRevoltist(true);
            addRemoveRevoltist.ShowDialog();
        }

        private void removeRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addRemoveRevoltist = new AddRemoveRevoltist(false);
            addRemoveRevoltist.ShowDialog();
        }

        private void promoteRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editForm = new EditRevoltistsTitle();
            editForm.ShowDialog();
        }

        private void demoteRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editForm = new EditRevoltistsTitle();
            editForm.ShowDialog();
        }
    }
}
