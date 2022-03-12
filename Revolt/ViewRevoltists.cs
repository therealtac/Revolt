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
    public partial class ViewRevoltists : Form
    {
        private readonly RevoltEntities _db;

        public ViewRevoltists()
        {
            InitializeComponent();
            _db = new RevoltEntities();
        }

        //when form loads, add all revoltists to the dataview, and all titles in the checked list box
        public void ViewRevoltists_Load(object sender, EventArgs e)
        {
            var revoltists = _db.Revoltists.Select(q => new { id = q.id, username = q.username, title = q.RevoltistTitle.title }).ToList();
            dvRevoltists.DataSource = revoltists;
            
            dvRevoltists.Columns["username"].HeaderText = "Username";
            dvRevoltists.Columns["title"].HeaderText = "Title";
            dvRevoltists.Columns["id"].Visible = false;

            clbTitles.Items.AddRange(Enum.GetNames(typeof(TitleEnum)));
        }

        //update checked list box whenever the numeric up down changes
        public void nupTitleLookup_ValueChanged(object sender, EventArgs e)
        {
            TitleEnum title = (TitleEnum)nupTitleLookup.Value;
            for(int i = 0; i < clbTitles.Items.Count; i++)
                if(Enum.TryParse(clbTitles.Items[i].ToString(), out TitleEnum t))
                        clbTitles.SetItemChecked(i, title.HasFlag(t));
        }

        //update the numeric up down whenever the check list box changes
        public void clbTitles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            long title = 0;
            foreach (int i in clbTitles.CheckedIndices)
                if (Enum.TryParse(clbTitles.Items[i].ToString(), out TitleEnum t))
                    title += (long)t;
            if (Enum.TryParse(clbTitles.Items[e.Index].ToString(), out TitleEnum tt))
                title += e.NewValue == CheckState.Checked ? (long)tt : -(long)tt;
            nupTitleLookup.Value = title;
        }
    }
}
