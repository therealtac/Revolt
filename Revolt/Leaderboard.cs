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
    public partial class Leaderboard : Form
    {
        private readonly RevoltEntities _db;
        private int game;

        public Leaderboard(int game)
        {
            InitializeComponent();
            _db = new RevoltEntities();

            //one form for both games, keep track of it here
            //game one = 0, game two = 1
            this.game = game;
        }

        //when form loads, fill in the leaderboard
        private void Leaderboard_Load(object sender, EventArgs e)
        {
            //update leaderboard title
            String gameTitle = _db.Games.FirstOrDefault(q => q.id == game).game1;
            lblTitle.Text = $"{gameTitle} Leaderboard";

            //get all the scores that match the game, and order them high to low
            List<RevoltistGameScore> scores = _db.RevoltistGameScores.Where(q => q.gameId == game).OrderBy(q => q.score).ToList();
            scores.Reverse();

            for(int i = 0; i < tlpLeaderboard.RowCount; i++)
            {
                //add two lables into the layout
                Label lblUser = new Label();
                String revoltist = i < scores.Count ? scores[i].Revoltist.username : "";
                lblUser.Text = $"{i+1}. {revoltist}";
                Label lblScore = new Label();
                long score = i < scores.Count ? scores[i].score : 0;
                lblScore.Text = score.ToString();
                tlpLeaderboard.Controls.Add(lblUser, 0, i);
                tlpLeaderboard.Controls.Add(lblScore, 1, i);
            }
        }
    }
}
