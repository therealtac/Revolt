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
    public partial class Login : Form
    {
        private readonly RevoltEntities _db;

        public Login()
        {
            InitializeComponent();
            _db = new RevoltEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = tbUsername.Text.Trim();
                String password = tbPassword.Text;

                String hashedPassword = Utils.hashPassword(password);

                Revoltist user = _db.Revoltists.FirstOrDefault(q => q.username == username && q.password == hashedPassword);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    Form mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.  Please try again");
            }
        }
    }
}
