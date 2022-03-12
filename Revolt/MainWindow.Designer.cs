namespace Revolt
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ssUser = new System.Windows.Forms.StatusStrip();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRevoltists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGames = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFirstGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnPlayFirstGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnLeaderboardFirstGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecondGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnPlaySecondGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnLeaderboardSecondGame = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.ssUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssUser
            // 
            this.ssUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUser});
            this.ssUser.Location = new System.Drawing.Point(0, 428);
            this.ssUser.Name = "ssUser";
            this.ssUser.Size = new System.Drawing.Size(800, 22);
            this.ssUser.TabIndex = 0;
            this.ssUser.Text = "statusStrip1";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRevoltists,
            this.menuMia,
            this.menuGames});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRevoltists
            // 
            this.menuRevoltists.Name = "menuRevoltists";
            this.menuRevoltists.Size = new System.Drawing.Size(69, 20);
            this.menuRevoltists.Text = "Revoltists";
            this.menuRevoltists.Click += new System.EventHandler(this.menuRevoltists_Click);
            // 
            // menuMia
            // 
            this.menuMia.Name = "menuMia";
            this.menuMia.Size = new System.Drawing.Size(39, 20);
            this.menuMia.Text = "Mia";
            this.menuMia.Click += new System.EventHandler(this.menuMia_Click);
            // 
            // menuGames
            // 
            this.menuGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFirstGame,
            this.menuSecondGame});
            this.menuGames.Name = "menuGames";
            this.menuGames.Size = new System.Drawing.Size(55, 20);
            this.menuGames.Text = "Games";
            // 
            // menuFirstGame
            // 
            this.menuFirstGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPlayFirstGame,
            this.tsbtnLeaderboardFirstGame});
            this.menuFirstGame.Name = "menuFirstGame";
            this.menuFirstGame.Size = new System.Drawing.Size(67, 22);
            // 
            // tsbtnPlayFirstGame
            // 
            this.tsbtnPlayFirstGame.Name = "tsbtnPlayFirstGame";
            this.tsbtnPlayFirstGame.Size = new System.Drawing.Size(140, 22);
            this.tsbtnPlayFirstGame.Text = "Play";
            this.tsbtnPlayFirstGame.Click += new System.EventHandler(this.tsbtnPlayFirstGame_Click);
            // 
            // tsbtnLeaderboardFirstGame
            // 
            this.tsbtnLeaderboardFirstGame.Name = "tsbtnLeaderboardFirstGame";
            this.tsbtnLeaderboardFirstGame.Size = new System.Drawing.Size(140, 22);
            this.tsbtnLeaderboardFirstGame.Text = "Leaderboard";
            this.tsbtnLeaderboardFirstGame.Click += new System.EventHandler(this.tsbtnLeaderboardFirstGame_Click);
            // 
            // menuSecondGame
            // 
            this.menuSecondGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPlaySecondGame,
            this.tsbtnLeaderboardSecondGame});
            this.menuSecondGame.Name = "menuSecondGame";
            this.menuSecondGame.Size = new System.Drawing.Size(67, 22);
            // 
            // tsbtnPlaySecondGame
            // 
            this.tsbtnPlaySecondGame.Name = "tsbtnPlaySecondGame";
            this.tsbtnPlaySecondGame.Size = new System.Drawing.Size(140, 22);
            this.tsbtnPlaySecondGame.Text = "Play";
            this.tsbtnPlaySecondGame.Click += new System.EventHandler(this.tsbtnPlaySecondGame_Click);
            // 
            // tsbtnLeaderboardSecondGame
            // 
            this.tsbtnLeaderboardSecondGame.Name = "tsbtnLeaderboardSecondGame";
            this.tsbtnLeaderboardSecondGame.Size = new System.Drawing.Size(140, 22);
            this.tsbtnLeaderboardSecondGame.Text = "Leaderboard";
            this.tsbtnLeaderboardSecondGame.Click += new System.EventHandler(this.tsbtnLeaderboardSecondGame_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(670, 427);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(106, 23);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.ssUser);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ssUser.ResumeLayout(false);
            this.ssUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRevoltists;
        private System.Windows.Forms.ToolStripMenuItem menuMia;
        private System.Windows.Forms.ToolStripMenuItem menuGames;
        private System.Windows.Forms.ToolStripMenuItem menuFirstGame;
        private System.Windows.Forms.ToolStripMenuItem menuSecondGame;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ToolStripMenuItem tsbtnPlayFirstGame;
        private System.Windows.Forms.ToolStripMenuItem tsbtnLeaderboardFirstGame;
        private System.Windows.Forms.ToolStripMenuItem tsbtnPlaySecondGame;
        private System.Windows.Forms.ToolStripMenuItem tsbtnLeaderboardSecondGame;
    }
}