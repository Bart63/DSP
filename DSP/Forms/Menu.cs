using DSP.Helpers;
using DSP.Signals;
using System;
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
    public partial class Menu : Form
    {
        private int numberOfCards = 0;

        private List<Card> cards = new List<Card>();

        public static Menu Instance;

        public Menu()
        {
            InitializeComponent();

            Instance = this;
        }

        private void RemoveCard(Card card)
        {
            cards.Remove(card);
        }

        private void buttonNewCard_Click(object sender, EventArgs e)
        {
            numberOfCards++;
            Card card = new Card(numberOfCards, RemoveCard);
            cards.Add(card);
            card.Show();
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations(cards);
            operations.ShowDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Signal signal = FileManager.Load();

            ShowCard(signal);
        }

        public void ShowCard(Signal signal)
        {
            if (signal != null)
            {
                numberOfCards++;
                Card card = new Card(numberOfCards, RemoveCard, signal);
                cards.Add(card);
                card.Show();
            }
        }

        private void buttonSimulator_Click(object sender, EventArgs e)
        {
            Simulator simulator = new Simulator();
            simulator.ShowDialog();
        }
    }
}
