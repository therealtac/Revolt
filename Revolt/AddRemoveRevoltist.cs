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
    public partial class AddRemoveRevoltist : Form
    {

        private readonly RevoltEntities _db;
        private bool _isAdding;

        public AddRemoveRevoltist(bool isAdding)
        {
            InitializeComponent();
            _db = new RevoltEntities();
            _isAdding = isAdding;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String username = cbRevoltist.Text;
            if (_isAdding)
            {
                Revoltist revoltist = new Revoltist();
                RevoltistTitle title = new RevoltistTitle();
                title.id = revoltist.id;
                title.title = (long)TitleEnum.NONE;
                revoltist.username = username;
                revoltist.password = Utils.defaultHashedPassword();
                _db.Revoltists.Add(revoltist);
                _db.RevoltistTitles.Add(title);
            }
            else
            {
                Revoltist revoltist = _db.Revoltists.FirstOrDefault(q => q.id == (int)cbRevoltist.SelectedValue);
                RevoltistTitle revoltistTitle = _db.RevoltistTitles.FirstOrDefault(q => q.id == (int)cbRevoltist.SelectedValue);
                _db.RevoltistTitles.Remove(revoltistTitle);
                _db.Revoltists.Remove(revoltist);
            }
            _db.SaveChanges();
            MessageBox.Show(_isAdding ? "Revoltist added!" : "Revoltist removed!");
            Close();
        }

        private void AddRemoveRevoltist_Load(object sender, EventArgs e)
        {
            List<Revoltist> revoltists = _db.Revoltists.ToList();
            cbRevoltist.DataSource = revoltists;
            cbRevoltist.DisplayMember = "username";
            cbRevoltist.ValueMember = "id";
        }
    }
}
