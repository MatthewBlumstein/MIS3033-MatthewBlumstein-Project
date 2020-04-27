using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Deck
    {
        public List<Card> cards { get; set; }
        public Deck()
        {
            cards = new List<Card>();
            char[] suits = { 'C', 'S', 'D', 'H' };
            for (int i = 0; i < 4; i++)
            {
                char suit = suits[i];
                for (int j = 2; j <= 14; j++)
                {
                    int rank = j;
                    string imageLocation;
                    if (rank == 11)
                    {
                        imageLocation = $"C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\J{suit}.jpg";
                    }
                    else if (rank == 12)
                    {
                        imageLocation = $"C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Q{suit}.jpg";
                    }
                    else if (rank == 13)
                    {
                        imageLocation = $"C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\K{suit}.jpg";
                    }
                    else if (rank == 14)
                    {
                        imageLocation = $"C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\A{suit}.jpg";
                    }
                    else
                    {
                        imageLocation = $"C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\{rank}{suit}.jpg";
                    }
                    Card card = new Card(suit, rank, imageLocation);
                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            int n = cards.Count;
            while(n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card swap = cards[k];
                cards[k] = cards[n];
                cards[n] = swap;
            }
        }

        public Card[] Deal()
        {
            Card[] hand = new Card[5];
            for(int i = 0; i < 5; i++)
            {
                hand[i] = cards[0];
                cards.RemoveAt(0);
            }
            return hand;
        }

        public void DealOne()
        {
            cards.RemoveAt(0);
        }
    }
    
}
