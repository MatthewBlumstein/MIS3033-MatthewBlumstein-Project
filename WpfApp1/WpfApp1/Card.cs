using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Card
    {
        char Suit { get; set; }
        int Rank { get; set; }
        string ImageLocation { get; set; }

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
