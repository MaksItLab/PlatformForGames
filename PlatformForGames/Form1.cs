﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformForGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTicTacToe game1 = new GameTicTacToe();
            game1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Snake game2 = new Snake();
            game2.Show();
        }
    }
}
