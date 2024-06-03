using System;
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
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Page
    {
        DB_BarbershopEntities db = new DB_BarbershopEntities();
        public Services()
        {
            InitializeComponent();
            DG_Services.ItemsSource = DB_BarbershopEntities.GetContext().Services_.ToList();
        }

        private void AddServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            var addServiceWindow = new AddingService();
            addServiceWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedService = (sender as Button).DataContext as database.Services_;
            var editServiceWindow = new AddingService(selectedService);
            editServiceWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
            DG_Services.ItemsSource = DB_BarbershopEntities.GetContext().Services_.ToList();
        }

        private void Search_Service_TextChanged(object sender, TextChangedEventArgs e)
        {
            DG_Services.ItemsSource = db.Services_.Where(k => k.Title.ToString().Contains(Search_Service.Text) || k.Price.ToString().Contains(Search_Service.Text)).ToList();
            if (Search_Service.Text == "")
            {
                DG_Services.ItemsSource = db.Services_.ToList();
            }
        }

        private void DeleteServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            var serviceforRemoving = DG_Services.SelectedItems.Cast<database.Services_>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {serviceforRemoving.Count()} элемент(а/ов)", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DB_BarbershopEntities.GetContext().Services_.RemoveRange(serviceforRemoving);
                    DB_BarbershopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");
                    DG_Services.ItemsSource = DB_BarbershopEntities.GetContext().Services_.ToList();
                }

                catch
                {
                    MessageBox.Show("Данные не удалены!");
                }
            }
        }
    }
}