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
        public MainWindow()
        {
            InitializeComponent();
            imgCard1.Source = new BitmapImage(new Uri("C:\\Users\\blum7476\\Downloads\\cards_jpeg_zip\\JPEG\\AH.jpg"));
            imgCard2.Source = new BitmapImage(new Uri("C:\\Users\\blum7476\\Downloads\\cards_jpeg_zip\\JPEG\\KH.jpg"));
            imgCard3.Source = new BitmapImage(new Uri("C:\\Users\\blum7476\\Downloads\\cards_jpeg_zip\\JPEG\\QH.jpg"));
            imgCard4.Source = new BitmapImage(new Uri("C:\\Users\\blum7476\\Downloads\\cards_jpeg_zip\\JPEG\\JH.jpg"));
            imgCard5.Source = new BitmapImage(new Uri("C:\\Users\\blum7476\\Downloads\\cards_jpeg_zip\\JPEG\\10H.jpg"));
        }
    }
}
