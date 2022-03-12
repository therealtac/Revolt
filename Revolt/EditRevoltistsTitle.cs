using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Revolt
{
    public partial class EditRevoltistsTitle : Form
    {

        private readonly RevoltEntities _db;

        public EditRevoltistsTitle()
        {
            InitializeComponent();
            _db = new RevoltEntities();
        }

        //when form loads, fill in the checked list box, and the combobox
        private void EditRevoltistsTitle_Load(object sender, EventArgs e)
        {
            clbTitles.Items.AddRange(Enum.GetNames(typeof(TitleEnum)));

            var revoltists = _db.Revoltists.Select(q => new { id = q.id, username = q.username, title = q.RevoltistTitle.title }).ToList();
            cbRevoltist.DataSource = revoltists;
            cbRevoltist.DisplayMember = "username";
            cbRevoltist.ValueMember = "id";
            cbRevoltist.SelectedIndex = -1;
        }

        //whenever the index changes in the combobox, update the checked list box with new titles
        private void cbRevoltist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRevoltist.SelectedIndex == -1) return;
            try
            {
                int id = (int)cbRevoltist.SelectedValue;
                Revoltist revoltist = _db.Revoltists.FirstOrDefault(q => q.id == id);
                TitleEnum title = (TitleEnum)revoltist.RevoltistTitle.title;
                for (int i = 0; i < clbTitles.Items.Count; i++)
                    if (Enum.TryParse(clbTitles.Items[i].ToString(), out TitleEnum t))
                        clbTitles.SetItemChecked(i, title.HasFlag(t));
            }
            catch (Exception)
            {
                
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            //add up the checked boxes to find the title value
            long title = 0;
            foreach (int i in clbTitles.CheckedIndices)
                if (Enum.TryParse(clbTitles.Items[i].ToString(), out TitleEnum t))
                    title += (long)t;
            try
            {
                int id = (int)cbRevoltist.SelectedValue;

                //update the title of revoltist
                _db.RevoltistTitles.FirstOrDefault(q => q.id == id).title = title;
                _db.SaveChanges();
                MessageBox.Show("Revoltist's titles updated!");
            }
            catch (Exception)
            {

            }
            Close();
        }
    }
}
