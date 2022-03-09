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

        private void EditRevoltistsTitle_Load(object sender, EventArgs e)
        {
            clbTitles.Items.AddRange(Enum.GetNames(typeof(TitleEnum)));

            var revoltists = _db.Revoltists.Select(q => new { id = q.id, username = q.username, title = q.RevoltistTitle.title }).ToList();
            cbRevoltist.DataSource = revoltists;
            cbRevoltist.DisplayMember = "username";
            cbRevoltist.ValueMember = "id";

            cbRevoltist.SelectedIndex = -1;
        }

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
    }
}
