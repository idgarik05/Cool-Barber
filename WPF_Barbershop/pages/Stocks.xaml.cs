using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using WPF_Barbershop.database;
using WPF_Barbershop.windows;

namespace WPF_Barbershop.pages
{
    /// <summary>
    /// Логика взаимодействия для Stocks.xaml
    /// </summary>
    public partial class Stocks : Page
    {

        DB_BarbershopEntities db = new DB_BarbershopEntities();
        public Stocks()
        {
            InitializeComponent();
            DG_Stocks.ItemsSource = DB_BarbershopEntities.GetContext().Stocks.ToList();

        }

        private void AddStockBtn_Click(object sender, RoutedEventArgs e)
        {
            var addStockWindow = new AddingStock();
            addStockWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void DeleteStockBtn_Click(object sender, RoutedEventArgs e)
        {
            var stocksforRemoving = DG_Stocks.SelectedItems.Cast<database.Stocks>().ToList();

            if(MessageBox.Show($"Вы точно хотите удалить следующие {stocksforRemoving.Count()} элемент(а/ов)","Внимание", MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DB_BarbershopEntities.GetContext().Stocks.RemoveRange(stocksforRemoving);
                    DB_BarbershopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");
                    DG_Stocks.ItemsSource = DB_BarbershopEntities.GetContext().Stocks.ToList(); 
                }

                catch 
                {
                    MessageBox.Show("Данные не удалены!");
                }
            }
        }

        private void Search_Stock_TextChanged(object sender, TextChangedEventArgs e)
        {
            DG_Stocks.ItemsSource = db.Stocks.Where(k => k.Title.ToString().Contains(Search_Stock.Text) || k.Discount_size.ToString().Contains(Search_Stock.Text)).ToList();
            if (Search_Stock.Text == "")
            {
                DG_Stocks.ItemsSource = db.Stocks.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedStock = (sender as Button).DataContext as database.Stocks;
            var editStockWindow = new AddingStock(selectedStock);
            editStockWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
            DG_Stocks.ItemsSource = DB_BarbershopEntities.GetContext().Stocks.ToList();
        }
    }
}