using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdBoard;

namespace BreadBord
{
    public partial class ADBoard : Form
    {
        public ADBoard()
        {
            InitializeComponent();
        }


        private void change_Scroll(object sender, ScrollEventArgs e)
        {
            bread.Interval = (int)change.Value;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play_Click(object sender, EventArgs e)
        {
            bread.Message = text.Text+"     ";
            bread.Play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            bread.Stop();
            if (k == 1)
            {
                play.Show();
                pictureBox2.Show();
                pictureBox1.Show();
                k = 0;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bread.Stop();
            text.Clear();
        }

        public int k = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            play.Hide();
            pictureBox2.Hide();
            pictureBox1.Hide();

            bread.Message = " Mohammad Khanjani      Email : Mohammadengkhanjani@gmail.com        ";
            bread.Play();
            k = 1;
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = Color.Green;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DeepSkyBlue;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DeepSkyBlue;
        }

        private void stop_MouseHover(object sender, EventArgs e)
        {
            stop.BackColor = Color.Green;
        }

        private void stop_MouseLeave(object sender, EventArgs e)
        {
            stop.BackColor = Color.DeepSkyBlue;
        }

        private void play_MouseHover(object sender, EventArgs e)
        {
            play.BackColor = Color.Green;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.BackColor = Color.DeepSkyBlue;
        }


    }
}
