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
    //if revoltist is queen, king, leader, or deputy, adds more options from ViewRevoltists form
    public partial class ManageRevoltists : ViewRevoltists
    {
        public ManageRevoltists() : base()
        {
            InitializeComponent();
        }

        //add revoltist, _isAdding = true
        private void addRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addRemoveRevoltist = new AddRemoveRevoltist(true);
            addRemoveRevoltist.ShowDialog();
        }

        //remove revoltist, _isAdding = false
        private void removeRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addRemoveRevoltist = new AddRemoveRevoltist(false);
            addRemoveRevoltist.ShowDialog();
        }

        //promote and demote are the same form here
        private void promoteRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editForm = new EditRevoltistsTitle();
            editForm.ShowDialog();
        }

        //promote and demote are the same form here
        private void demoteRevoltistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editForm = new EditRevoltistsTitle();
            editForm.ShowDialog();
        }
    }
}
