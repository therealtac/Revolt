﻿namespace Revolt
{
    partial class ManageRevoltists : ViewRevoltists
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editRevoltistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRevoltistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRevoltistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteRevoltistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoteRevoltistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRevoltistsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editRevoltistsToolStripMenuItem
            // 
            this.editRevoltistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRevoltistToolStripMenuItem,
            this.removeRevoltistToolStripMenuItem,
            this.promoteRevoltistToolStripMenuItem,
            this.demoteRevoltistToolStripMenuItem});
            this.editRevoltistsToolStripMenuItem.Name = "editRevoltistsToolStripMenuItem";
            this.editRevoltistsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.editRevoltistsToolStripMenuItem.Text = "Edit Revoltists";
            // 
            // addRevoltistToolStripMenuItem
            // 
            this.addRevoltistToolStripMenuItem.Name = "addRevoltistToolStripMenuItem";
            this.addRevoltistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRevoltistToolStripMenuItem.Text = "Add Revoltist";
            this.addRevoltistToolStripMenuItem.Click += new System.EventHandler(this.addRevoltistToolStripMenuItem_Click);
            // 
            // removeRevoltistToolStripMenuItem
            // 
            this.removeRevoltistToolStripMenuItem.Name = "removeRevoltistToolStripMenuItem";
            this.removeRevoltistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeRevoltistToolStripMenuItem.Text = "Remove Revoltist";
            this.removeRevoltistToolStripMenuItem.Click += new System.EventHandler(this.removeRevoltistToolStripMenuItem_Click);
            // 
            // promoteRevoltistToolStripMenuItem
            // 
            this.promoteRevoltistToolStripMenuItem.Name = "promoteRevoltistToolStripMenuItem";
            this.promoteRevoltistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promoteRevoltistToolStripMenuItem.Text = "Promote Revoltist";
            this.promoteRevoltistToolStripMenuItem.Click += new System.EventHandler(this.promoteRevoltistToolStripMenuItem_Click);
            // 
            // demoteRevoltistToolStripMenuItem
            // 
            this.demoteRevoltistToolStripMenuItem.Name = "demoteRevoltistToolStripMenuItem";
            this.demoteRevoltistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.demoteRevoltistToolStripMenuItem.Text = "Demote Revoltist";
            this.demoteRevoltistToolStripMenuItem.Click += new System.EventHandler(this.demoteRevoltistToolStripMenuItem_Click);
            // 
            // ManageRevoltists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageRevoltists";
            this.Text = "ManageRevoltists";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editRevoltistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRevoltistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRevoltistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoteRevoltistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoteRevoltistToolStripMenuItem;
    }
}