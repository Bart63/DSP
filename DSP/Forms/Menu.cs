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

        public Menu()
        {
            InitializeComponent();

        }

        private void buttonNewCard_Click(object sender, EventArgs e)
        {
            numberOfCards++;
            Card card = new Card(numberOfCards);
            cards.Add(card);
            card.Show();
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations(cards);
            operations.ShowDialog();
        }
    }
}
