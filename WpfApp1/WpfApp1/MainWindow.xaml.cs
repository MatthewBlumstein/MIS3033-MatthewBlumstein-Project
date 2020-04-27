using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int current = 100;
        int bet = 1;
        int winnings = 0;
        bool canChange = true;
        bool canDraw = true;
        bool canSwap = false;
        bool canClose = true;
        Deck deck;
        Card[] hand;
        public MainWindow()
        {
            InitializeComponent();
            lblCurrent.Content = $"Current: {current}";
            lblBet.Content = $"Bet: {bet}";
            lblWin.Content = $"Win: {winnings}";
            imgCard1.Source = new BitmapImage(new Uri("C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Red_back.jpg"));
            imgCard2.Source = new BitmapImage(new Uri("C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Red_back.jpg"));
            imgCard3.Source = new BitmapImage(new Uri("C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Red_back.jpg"));
            imgCard4.Source = new BitmapImage(new Uri("C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Red_back.jpg"));
            imgCard5.Source = new BitmapImage(new Uri("C:\\Users\\Acer\\Downloads\\cards_jpeg_zip\\JPEG\\Red_back.jpg"));
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(canChange)
            {
                bet = 1;
                lblBet.Content = $"Bet: {bet}";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (canChange)
            {
                bet = 2;
                lblBet.Content = $"Bet: {bet}";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (canChange)
            {
                bet = 3;
                lblBet.Content = $"Bet: {bet}";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (canChange)
            {
                bet = 4;
                lblBet.Content = $"Bet: {bet}";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (canChange)
            {
                bet = 5;
                lblBet.Content = $"Bet: {bet}";
            }
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            if (canDraw)
            {
                canClose = false;
                winnings = 0;
                canChange = false;
                canDraw = false;
                canSwap = true;
                deck = new Deck();
                deck.Shuffle();
                hand = deck.Deal();
                imgCard1.Source = new BitmapImage(new Uri(hand[0].ImageLocation));
                imgCard2.Source = new BitmapImage(new Uri(hand[1].ImageLocation));
                imgCard3.Source = new BitmapImage(new Uri(hand[2].ImageLocation));
                imgCard4.Source = new BitmapImage(new Uri(hand[3].ImageLocation));
                imgCard5.Source = new BitmapImage(new Uri(hand[4].ImageLocation));
            
                current = current - bet;
                lblCurrent.Content = $"Current: {current}";
            }
        }

        private void btnSwap_Click(object sender, RoutedEventArgs e)
        {
            if (canSwap)
            {
                canSwap = false;
                if (!(bool)chkHold1.IsChecked)
                {
                    hand[0] = deck.cards[0];
                    deck.DealOne();
                    imgCard1.Source = new BitmapImage(new Uri(hand[0].ImageLocation));
                }
                if (!(bool)chkHold2.IsChecked)
                {
                    hand[1] = deck.cards[0];
                    deck.DealOne();
                    imgCard2.Source = new BitmapImage(new Uri(hand[1].ImageLocation));
                }
                if (!(bool)chkHold3.IsChecked)
                {
                    hand[2] = deck.cards[0];
                    deck.DealOne();
                    imgCard3.Source = new BitmapImage(new Uri(hand[2].ImageLocation));
                }
                if (!(bool)chkHold4.IsChecked)
                {
                    hand[3] = deck.cards[0];
                    deck.DealOne();
                    imgCard4.Source = new BitmapImage(new Uri(hand[3].ImageLocation));
                }
                if (!(bool)chkHold5.IsChecked)
                {
                    hand[4] = deck.cards[0];
                    deck.DealOne();
                    imgCard5.Source = new BitmapImage(new Uri(hand[4].ImageLocation));
                }

                int[] suits = { 0, 0, 0, 0 };
                for (int i = 0; i < 5; i++)
                {
                    if (hand[i].Suit == 'C')
                    {
                        suits[0] = suits[0] + 1;
                    }
                    if (hand[i].Suit == 'S')
                    {
                        suits[1] = suits[1] + 1;
                    }
                    if (hand[i].Suit == 'D')
                    {
                        suits[2] = suits[2] + 1;
                    }
                    if (hand[i].Suit == 'H')
                    {
                        suits[3] = suits[3] + 1;
                    }
                }

                int[] ranks = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < 5; i++)
                {
                    if (hand[i].Rank == 2)
                    {
                        ranks[0] = ranks[0] + 1; ;
                    }
                    if (hand[i].Rank == 3)
                    {
                        ranks[1] = ranks[1] + 1;
                    }
                    if (hand[i].Rank == 4)
                    {
                        ranks[2] = ranks[2] + 1;
                    }
                    if (hand[i].Rank == 5)
                    {
                        ranks[3] = ranks[3] + 1;
                    }
                    if (hand[i].Rank == 6)
                    {
                        ranks[4] = ranks[4] + 1;
                    }
                    if (hand[i].Rank == 7)
                    {
                        ranks[5] = ranks[5] + 1;
                    }
                    if (hand[i].Rank == 8)
                    {
                        ranks[6] = ranks[6] + 1;
                    }
                    if (hand[i].Rank == 9)
                    {
                        ranks[7] = ranks[7] + 1;
                    }
                    if (hand[i].Rank == 10)
                    {
                        ranks[8] = ranks[8] + 1;
                    }
                    if (hand[i].Rank == 11)
                    {
                        ranks[9] = ranks[9] + 1;
                    }
                    if (hand[i].Rank == 12)
                    {
                        ranks[10] = ranks[10] + 1;
                    }
                    if (hand[i].Rank == 13)
                    {
                        ranks[11] = ranks[11] + 1;
                    }
                    if (hand[i].Rank == 14)
                    {
                        ranks[12] = ranks[12] + 1;
                    }
                }

                bool isStraight = false;
                for (int i = 0; i < ranks.Length; i++)
                {
                    if (ranks[i] == 1)
                    {
                        try
                        {
                            if (ranks[i + 1] == 1 && ranks[i + 2] == 1 && ranks[i + 3] == 1 && ranks[i + 4] == 1)
                            {
                                isStraight = true;
                            }
                        }
                        catch
                        {

                        }
                    }
                }

                bool isFlush = false;
                if (suits[0] == 5 || suits[1] == 5 || suits[2] == 5 || suits[3] == 5 )
                {
                    isFlush = true;
                }

                bool isFourKind = false;
                for(int i = 0; i < ranks.Length; i++)
                {
                    if(ranks[i] == 4)
                    {
                        isFourKind = true;
                    }
                }

                bool isThreeKind = false;
                for (int i = 0; i < ranks.Length; i++)
                {
                    if (ranks[i] == 3)
                    {
                        isThreeKind = true;
                    }
                }

                bool isTwoKind = false;
                bool isTwoPair = false;
                for (int i = 0; i < ranks.Length; i++)
                {
                    if (ranks[i] == 2)
                    {
                        if(isTwoKind)
                        {
                            isTwoPair = true;
                        }
                        isTwoKind = true;
                    }
                }

                bool isJacks = false;
                if(ranks[9] == 2 || ranks[10] == 2 || ranks[11] == 2 || ranks[12] == 2)
                {
                    isJacks = true;
                }


                if (isStraight && isFlush && ranks[12] == 1)
                {
                    if (bet == 1)
                    {
                        winnings = 250;
                    }
                    else if (bet == 2)
                    {
                        winnings = 500;
                    }
                    else if (bet == 3)
                    {
                        winnings = 750;
                    }
                    else if (bet == 4)
                    {
                        winnings = 1000;
                    }
                    else
                    {
                        winnings = 4000;
                    }
                }

                else if (isStraight && isFlush)
                {
                    if (bet == 1)
                    {
                        winnings = 50;
                    }
                    else if (bet == 2)
                    {
                        winnings = 100;
                    }
                    else if (bet == 3)
                    {
                        winnings = 150;
                    }
                    else if (bet == 4)
                    {
                        winnings = 200;
                    }
                    else
                    {
                        winnings = 250;
                    }
                }

                else if (isFourKind)
                {
                    if (bet == 1)
                    {
                        winnings = 25;
                    }
                    else if (bet == 2)
                    {
                        winnings = 50;
                    }
                    else if (bet == 3)
                    {
                        winnings = 75;
                    }
                    else if (bet == 4)
                    {
                        winnings = 100;
                    }
                    else
                    {
                        winnings = 125;
                    }
                }

                else if (isThreeKind && isTwoKind)
                {
                    if (bet == 1)
                    {
                        winnings = 9;
                    }
                    else if (bet == 2)
                    {
                        winnings = 18;
                    }
                    else if (bet == 3)
                    {
                        winnings = 27;
                    }
                    else if (bet == 4)
                    {
                        winnings = 36;
                    }
                    else
                    {
                        winnings = 45;
                    }
                }

                else if (isFlush)
                {
                    if (bet == 1)
                    {
                        winnings = 6;
                    }
                    else if (bet == 2)
                    {
                        winnings = 12;
                    }
                    else if (bet == 3)
                    {
                        winnings = 18;
                    }
                    else if (bet == 4)
                    {
                        winnings = 24;
                    }
                    else
                    {
                        winnings = 30;
                    }
                }

                else if (isStraight)
                {
                    if (bet == 1)
                    {
                        winnings = 4;
                    }
                    else if (bet == 2)
                    {
                        winnings = 8;
                    }
                    else if (bet == 3)
                    {
                        winnings = 12;
                    }
                    else if (bet == 4)
                    {
                        winnings = 16;
                    }
                    else
                    {
                        winnings = 20;
                    }
                }

                else if (isThreeKind)
                {
                    if (bet == 1)
                    {
                        winnings = 3;
                    }
                    else if (bet == 2)
                    {
                        winnings = 6;
                    }
                    else if (bet == 3)
                    {
                        winnings = 9;
                    }
                    else if (bet == 4)
                    {
                        winnings = 12;
                    }
                    else
                    {
                        winnings = 15;
                    }
                }

                else if (isTwoPair)
                {
                    if (bet == 1)
                    {
                        winnings = 2;
                    }
                    else if (bet == 2)
                    {
                        winnings = 4;
                    }
                    else if (bet == 3)
                    {
                        winnings = 6;
                    }
                    else if (bet == 4)
                    {
                        winnings = 8;
                    }
                    else
                    {
                        winnings = 10;
                    }
                }

                else if (isJacks)
                {
                    if (bet == 1)
                    {
                        winnings = 1;
                    }
                    else if (bet == 2)
                    {
                        winnings = 2;
                    }
                    else if (bet == 3)
                    {
                        winnings = 3;
                    }
                    else if (bet == 4)
                    {
                        winnings = 4;
                    }
                    else
                    {
                        winnings = 5;
                    }
                }

                current = current + winnings;
                lblCurrent.Content = $"Current: {current}";
                lblWin.Content = $"Win : {winnings}";

                if(current == 0)
                {
                    MessageBox.Show("OUT OF CREDITS");
                    Close();
                }

                canDraw = true;
                canChange = true;
                canClose = true;
            }
        }

        private void btnCashOut_Click(object sender, RoutedEventArgs e)
        {
            if (canClose)
            {
                MessageBox.Show(current.ToString());
                Close();
            }
        }
    }
}
