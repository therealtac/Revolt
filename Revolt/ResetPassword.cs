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
    public partial class ResetPassword : Form
    {

        private readonly RevoltEntities _db;
        private Revoltist _revoltist;

        public ResetPassword(Revoltist revoltist)
        {
            InitializeComponent();
            _db = new RevoltEntities();
            _revoltist = revoltist;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                String password = tbNewPassword.Text;
                String confirmPassword = tbConfirmPassword.Text;

                //get user whose password to change
                Revoltist user = _db.Revoltists.FirstOrDefault(q => q.id == _revoltist.id);

                //if passwords do not match, try again
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.  Please try again!");
                }

                user.password = Utils.hashPassword(password);
                _db.SaveChanges();
                MessageBox.Show("Password was reset succesfully");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error, please try again");
            }
        }
    }
}
