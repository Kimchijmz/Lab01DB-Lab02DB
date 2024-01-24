using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab02DB.Displays;
using Lab02DB.Models1;

namespace Lab02DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Store> stores;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BlossomBooks(object sender, RoutedEventArgs e)
        {
            BlossomBooks blossomBooks = new BlossomBooks();
            BlossomBooks WindowBlossom = blossomBooks;
            WindowBlossom.Show();
            this.Close();
        }

        private void GadgetGalaxy(object sender, RoutedEventArgs e)
        {

        }

        private void TastyTreatsGrocery(object sender, RoutedEventArgs e)
        {

        }

        private void OutdoorAdventures(object sender, RoutedEventArgs e)
        {

        }

        private void FashionFusion(object sender, RoutedEventArgs e)
        {

        }
    }
}