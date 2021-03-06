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
    public partial class MainWindow : Form
    {
        private readonly RevoltEntities _db;
        private Login _login;
        public Revoltist _revoltist;

        public MainWindow()
        {
            InitializeComponent();
            _db = new RevoltEntities();
        }

        public MainWindow(Login login, Revoltist revoltist)
        {
            InitializeComponent();
            _login = login;
            _revoltist = revoltist;
            _db = new RevoltEntities();
        }

        private void menuRevoltists_Click(object sender, EventArgs e)
        {
            //get revoltists titles
            TitleEnum title = (TitleEnum)_revoltist.RevoltistTitle.title;

            //if revoltist is either queen, king, leader, or deputy, they have access to the ManageRevoltists form, 
            //other users can only view
            if (title.HasFlag(TitleEnum.QUEEN) || title.HasFlag(TitleEnum.KING) || title.HasFlag(TitleEnum.LEADER) || title.HasFlag(TitleEnum.DEPUTY))
            {
                Form manageRevoltists = new ManageRevoltists();
                manageRevoltists.ShowDialog();
                manageRevoltists.MdiParent = this;
            }
            else
            {
                Form viewRevoltists = new ViewRevoltists();
                viewRevoltists.ShowDialog();
                viewRevoltists.MdiParent = this;
            }
        }

        //when form loads, check if revoltist is new and has a default password, 
        //and change it if it does
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_revoltist.password == Utils.defaultHashedPassword())
            {
                Form resetPassword = new ResetPassword(_revoltist);
                resetPassword.ShowDialog();
            }
            tsslUser.Text = $"User: {_revoltist.username}";

            //update game names to names in the db
            menuFirstGame.Text = _db.Games.FirstOrDefault(q => q.id == 0).game1;
            menuSecondGame.Text = _db.Games.FirstOrDefault(q => q.id == 1).game1;
        }

        //reset password
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Form resetPassword = new ResetPassword(_revoltist);
            resetPassword.ShowDialog();
        }

        //play first game
        private void tsbtnPlayFirstGame_Click(object sender, EventArgs e)
        {
            Form game = new GameOne(_revoltist);
            game.ShowDialog();
        }

        //view first games leaderboard (0 = firstgame)
        private void tsbtnLeaderboardFirstGame_Click(object sender, EventArgs e)
        {
            Form leaderboard = new Leaderboard(0);
            leaderboard.ShowDialog();
        }

        //play second game
        private void tsbtnPlaySecondGame_Click(object sender, EventArgs e)
        {
            //implement if I have time
        }

        //view second games leaderboard (1 = secondgame)
        private void tsbtnLeaderboardSecondGame_Click(object sender, EventArgs e)
        {
            Form leaderboard = new Leaderboard(1);
            leaderboard.ShowDialog();
        }

        //view mia pictures
        private void menuMia_Click(object sender, EventArgs e)
        {
            Form miaSlideshow = new Slideshow();
            miaSlideshow.ShowDialog();
        }
    }
}
