﻿using System;
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
        private Login _login;
        public Revoltist _revoltist;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, Revoltist revoltist)
        {
            InitializeComponent();
            _login = login;
            _revoltist = revoltist;
        }

        private void menuRevoltists_Click(object sender, EventArgs e)
        {
            TitleEnum title = (TitleEnum)_revoltist.RevoltistTitle.title;
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
    }
}
