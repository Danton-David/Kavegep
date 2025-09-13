using System.Security.Cryptography.X509Certificates;
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

namespace KávégépAutomata_Ulicny_Balássy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            uzenet.Text = "Ennyit kell fizetni: ";
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            uzenet.Text = "Jó napot :)";
        }
        private void Espresso_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Americano_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Cappuccino_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Latte_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Macchiato_Click(object sender, RoutedEventArgs e)
        {

        }
        private void White_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Mocha_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Cortado_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Ristretto_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Affogato_Click(object sender, RoutedEventArgs e)
        {

        }
        private void IcedCoffee_Click(object sender, RoutedEventArgs e)
        {

        }
        private void IcedLatte_Click(object sender, RoutedEventArgs e)
        {

        }
        private void HotCocoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void osszeg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}