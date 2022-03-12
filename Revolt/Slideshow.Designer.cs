namespace Revolt
{
    partial class Slideshow
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
            this.picMia = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMia)).BeginInit();
            this.SuspendLayout();
            // 
            // picMia
            // 
            this.picMia.Location = new System.Drawing.Point(21, 116);
            this.picMia.Name = "picMia";
            this.picMia.Size = new System.Drawing.Size(263, 361);
            this.picMia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMia.TabIndex = 0;
            this.picMia.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucy Said Ok Personal Use", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mia!!!";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(310, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMia);
            this.Name = "Slideshow";
            this.Text = "Slideshow";
            this.Load += new System.EventHandler(this.Slideshow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}