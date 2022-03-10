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
            this.game = game;
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

            String gameTitle = _db.Games.FirstOrDefault(q => q.id == game).game1;
            lblTitle.Text = $"{gameTitle} Leaderboard";

            List<RevoltistGameScore> scores = _db.RevoltistGameScores.Where(q => q.gameId == game).OrderBy(q => q.score).ToList();
            scores.Reverse();

            for(int i = 0; i < tlpLeaderboard.RowCount; i++)
            {
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
