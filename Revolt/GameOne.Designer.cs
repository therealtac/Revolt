namespace Revolt
{
    partial class GameOne
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.picChicken = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.picMia = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMia)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(86, 24);
            this.scoreText.TabIndex = 10;
            this.scoreText.Text = "Score - 0";
            // 
            // picChicken
            // 
            this.picChicken.Image = global::Revolt.Properties.Resources.chicken1;
            this.picChicken.Location = new System.Drawing.Point(505, 295);
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(61, 43);
            this.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChicken.TabIndex = 11;
            this.picChicken.TabStop = false;
            this.picChicken.Tag = "chicken";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Green;
            this.floor.Location = new System.Drawing.Point(-39, 417);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(878, 50);
            this.floor.TabIndex = 6;
            this.floor.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::Revolt.Properties.Resources.fryer;
            this.obstacle2.Location = new System.Drawing.Point(712, 375);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(52, 45);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 9;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::Revolt.Properties.Resources.Layla__1_;
            this.obstacle1.Location = new System.Drawing.Point(375, 375);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(45, 45);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 8;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // picMia
            // 
            this.picMia.Image = global::Revolt.Properties.Resources.Mia;
            this.picMia.Location = new System.Drawing.Point(105, 360);
            this.picMia.Name = "picMia";
            this.picMia.Size = new System.Drawing.Size(59, 60);
            this.picMia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMia.TabIndex = 7;
            this.picMia.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picChicken);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.picMia);
            this.KeyPreview = true;
            this.Name = "GameOne";
            this.Text = "GameOne";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOne_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameOne_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox picMia;
        private System.Windows.Forms.Timer timer;
    }
}