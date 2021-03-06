﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    public partial class Controller_MainForm : Form
    {
        View view;
        Model model;

        Thread modelPlay;

        public Controller_MainForm() : this(260) { }
        public Controller_MainForm(int sizeField) : this(sizeField, 5) { }
        public Controller_MainForm(int sizeField, int amountTanks) : this (sizeField, amountTanks, 5) { }
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, 40) { }

        public Controller_MainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();

            model = new Model(sizeField, amountTanks, amountApples, speedGame);

            view = new View(model);
            this.Controls.Add(view);
        }

        private void StartStop_btn_Click(object sender, EventArgs e)
        {
            if (model.gamestatus == GameStatus.playing)
            {
                modelPlay.Abort();
                model.gamestatus = GameStatus.stoping;
            }
            else
            {
                model.gamestatus = GameStatus.playing;
                modelPlay = new Thread(model.Play);
                modelPlay.Start();

                view.Invalidate();
            }
        }

        private void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                model.gamestatus = GameStatus.stoping;
                modelPlay.Abort();
            }

            DialogResult dr = MessageBox.Show("Игра закрывается","Танки", MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;


        }
    }
}
