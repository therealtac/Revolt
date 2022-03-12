namespace Revolt
{
    partial class ViewRevoltists
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvRevoltists = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nupTitleLookup = new System.Windows.Forms.NumericUpDown();
            this.clbTitles = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvRevoltists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTitleLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucy Said Ok Personal Use", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chihuahua Revoltists";
            // 
            // dvRevoltists
            // 
            this.dvRevoltists.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dvRevoltists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRevoltists.Location = new System.Drawing.Point(12, 106);
            this.dvRevoltists.Name = "dvRevoltists";
            this.dvRevoltists.Size = new System.Drawing.Size(282, 332);
            this.dvRevoltists.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucy Said Ok Personal Use", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title Lookup";
            // 
            // nupTitleLookup
            // 
            this.nupTitleLookup.Location = new System.Drawing.Point(454, 160);
            this.nupTitleLookup.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.nupTitleLookup.Name = "nupTitleLookup";
            this.nupTitleLookup.Size = new System.Drawing.Size(147, 20);
            this.nupTitleLookup.TabIndex = 4;
            this.nupTitleLookup.ValueChanged += new System.EventHandler(this.nupTitleLookup_ValueChanged);
            // 
            // clbTitles
            // 
            this.clbTitles.BackColor = System.Drawing.Color.PaleGreen;
            this.clbTitles.CheckOnClick = true;
            this.clbTitles.FormattingEnabled = true;
            this.clbTitles.Location = new System.Drawing.Point(309, 201);
            this.clbTitles.MultiColumn = true;
            this.clbTitles.Name = "clbTitles";
            this.clbTitles.Size = new System.Drawing.Size(498, 229);
            this.clbTitles.TabIndex = 5;
            this.clbTitles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTitles_ItemCheck);
            // 
            // ViewRevoltists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.clbTitles);
            this.Controls.Add(this.nupTitleLookup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvRevoltists);
            this.Controls.Add(this.label1);
            this.Name = "ViewRevoltists";
            this.Text = "ViewRevoltists";
            this.Load += new System.EventHandler(this.ViewRevoltists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvRevoltists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTitleLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvRevoltists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupTitleLookup;
        private System.Windows.Forms.CheckedListBox clbTitles;
    }
}