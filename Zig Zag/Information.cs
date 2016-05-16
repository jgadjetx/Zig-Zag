﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e00c(0)_256b2.png");
            pictureBoxBack.BackgroundImage = image;
            labelBack.Visible = true;
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e00c(0)_256b1.png");
            pictureBoxBack.BackgroundImage = image;
            labelBack.Visible = false;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FunctionalWindow child = new FunctionalWindow();
            ActiveForm.Hide();
            child.Show();
        }

        private void Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}