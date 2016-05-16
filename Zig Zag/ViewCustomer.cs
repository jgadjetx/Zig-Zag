﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            Customers child = new Customers();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBox2.Size = size;
            Size size2 = new Size(450, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(165, 451);
            pictureBox2.Location = new Point(464, 540);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e0c3(0)_256.png");
            pictureBox2.BackgroundImage = image;
            labelSystem.Text = "Detail of all pet owners with pets";
            labelSystem.Location = new Point(168, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(461, 540);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e0c3(0)_2561.png");
            pictureBox2.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBoxOver50_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxOver50.Size = size;
            Size size2 = new Size(450, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(165, 451);
            pictureBoxOver50.Location = new Point(598, 538);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e07c(1)_256.png");
            pictureBoxOver50.BackgroundImage = image;
            labelSystem.Text = "Details of pet owners";
            labelSystem.Location = new Point(250, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxOver50_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxOver50.Size = size;
            pictureBoxOver50.Location = new Point(607, 540);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e07c(1)_2561.png");
            pictureBoxOver50.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet12.list_detail_of_all_pet_owners_with_pets' table. You can move, or remove it, as needed.
            this.list_detail_of_all_pet_owners_with_petsTableAdapter.Fill(this.d25535935DataSet12.list_detail_of_all_pet_owners_with_pets);
            // TODO: This line of code loads data into the 'd25535935DataSet11.details_of_pet_owners' table. You can move, or remove it, as needed.
            this.details_of_pet_ownersTableAdapter.Fill(this.d25535935DataSet11.details_of_pet_owners);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridViewPetOwnerWithPet.Visible = false;
            dataGridViewPetOwner.Visible = true;
        }

        private void pictureBoxOver50_Click(object sender, EventArgs e)
        {
            dataGridViewPetOwnerWithPet.Visible = true;
            dataGridViewPetOwner.Visible = false;
        }
    }
}