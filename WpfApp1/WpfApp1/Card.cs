using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Card
    {
        public char Suit { get; set; }
        public int Rank { get; set; }
        public string ImageLocation { get; set; }

        public Card()
        {
            Suit = ' ';
            Rank = 0;
            ImageLocation = "";
        }

        public Card(char suit, int rank, string imageLocation)
        {
            Suit = suit;
            Rank = rank;
            ImageLocation = imageLocation;
        }
    }
}
