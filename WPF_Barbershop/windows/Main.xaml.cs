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
using System.Windows.Shapes;
using WPF_Barbershop.pages;

namespace WPF_Barbershop.windows
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            Frame.Navigate(new Records());
        }

        private void RecordBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Records());
        }

        private void BarberBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Barbers());
        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Clients());
        }
        private void ServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Services());
        }

        private void StocksBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Stocks());
        }
    }
}
