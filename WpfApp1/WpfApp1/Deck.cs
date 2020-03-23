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
            char[] suits = { 'C', 'S', 'D', 'H' };
            for(int i = 0; i < 4; i++)
            {
                char suit = suits[i];
                for(int j = 2; j < 14; j++)
                {
                    int rank = j;
                    string imageLocation;
                    if(rank == 10)
                    {
                        imageLocation = $"C: \\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\J{suit}.jpg";
                    }
                    else if(rank == 11)
                    {
                        imageLocation = $"C: \\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Q{suit}.jpg";
                    }
                    else if (rank == 12)
                    {
                        imageLocation = $"C: \\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\{suit}.jpg";
                    }
                    else if (rank == 13)
                    {
                        imageLocation = $"C: \\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\A{suit}.jpg";
                    }
                    else
                    {
                        imageLocation = $"C: \\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\{rank}{suit}.jpg";
                    }
                    Card card = new Card(suit, rank, imageLocation);
                    cards.Add(card);
                }
            }
        }
    }
}
