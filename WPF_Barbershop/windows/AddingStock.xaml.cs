using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WPF_Barbershop.database;

namespace WPF_Barbershop.windows
{
    /// <summary>
    /// Логика взаимодействия для AddingStock.xaml
    /// </summary>
    public partial class AddingStock : Window
    {
        private Stocks _stock;

        public AddingStock()
        {
            InitializeComponent();
        }

        public AddingStock(Stocks stock)
        {
            InitializeComponent();
            _stock = stock;

            NameStock.Text = _stock.Title;
            DiscountSize.Text = _stock.Discount_size.ToString();
            StartDateStock.Text = _stock.Start_date_.ToString("yyyy-MM-dd");
            EndDateStock.Text = _stock.End_date_.ToString("yyyy-MM-dd");
        }

        private void BackMain_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Main();
            mainWindow.Show();
            Close();
        }

        private void RegistStockBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены в правильности заполненных данных?", "", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    if (_stock == null)
                    {
                        // Adding new stock
                        _stock = new Stocks();
                        _stock.Title = NameStock.Text;
                        _stock.Discount_size = float.Parse(DiscountSize.Text);
                        _stock.Start_date_ = DateTime.Parse(StartDateStock.Text);
                        _stock.End_date_ = DateTime.Parse(EndDateStock.Text);
                        DB_BarbershopEntities.GetContext().Stocks.Add(_stock);
                    }
                    else
                    {
                        // Editing existing stock
                        _stock.Title = NameStock.Text;
                        _stock.Discount_size = float.Parse(DiscountSize.Text);
                        _stock.Start_date_ = DateTime.Parse(StartDateStock.Text);
                        _stock.End_date_ = DateTime.Parse(EndDateStock.Text);
                    }

                    DB_BarbershopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные сохранены!");

                    var backMainWindow = new Main();
                    backMainWindow.Show();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Данные заполнены неверно, исправьте их и повторите попытку!");
                }
            }
        }
    }
}