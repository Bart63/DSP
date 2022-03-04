﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP
{
    public partial class Operations : Form
    {
        private List<Card> cards;

        private List<Card> selectedCards = new List<Card>();

        private List<CheckBox> checkBoxes = new List<CheckBox>();

        public Operations(List<Card> cards)
        {
            InitializeComponent();

            this.cards = cards;

            checkBoxes = new List<CheckBox>();

            foreach (Card card in cards)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = card.GetName();
                checkBox.Click += OnCheckboxClick;


                flowLayoutPanel1.Controls.Add(checkBox);

                checkBoxes.Add(checkBox);
            }
        }

        private void OnCheckboxClick(object sender, EventArgs e)
        {
            string name = ((CheckBox)sender).Text;
            Card card = cards.Find(x => x.GetName() == name);
            
            if (selectedCards.Exists(x => x == card))
            {
                selectedCards.Remove(card);
            }
            else
            {
                if (selectedCards.Count == 2)
                {
                    checkBoxes.Find(x => x.Text == selectedCards[0].GetName()).Checked = false;
                    selectedCards.RemoveAt(0);
                    selectedCards.Add(card);
                }
                else
                {
                    selectedCards.Add(card);
                }
            }
        }

        private void Operations_Load(object sender, EventArgs e)
        {

        }
    }
}