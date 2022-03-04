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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRevoltists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGames = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMiaRun = new System.Windows.Forms.ToolStripMenuItem();
            this.game2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            // 
            // menuGames
            // 
            this.menuGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMiaRun,
            this.game2ToolStripMenuItem});
            this.menuGames.Name = "menuGames";
            this.menuGames.Size = new System.Drawing.Size(55, 20);
            this.menuGames.Text = "Games";
            // 
            // menuMiaRun
            // 
            this.menuMiaRun.Name = "menuMiaRun";
            this.menuMiaRun.Size = new System.Drawing.Size(180, 22);
            this.menuMiaRun.Text = "Mia Run";
            // 
            // game2ToolStripMenuItem
            // 
            this.game2ToolStripMenuItem.Name = "game2ToolStripMenuItem";
            this.game2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.game2ToolStripMenuItem.Text = "Game2";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRevoltists;
        private System.Windows.Forms.ToolStripMenuItem menuMia;
        private System.Windows.Forms.ToolStripMenuItem menuGames;
        private System.Windows.Forms.ToolStripMenuItem menuMiaRun;
        private System.Windows.Forms.ToolStripMenuItem game2ToolStripMenuItem;
    }
}