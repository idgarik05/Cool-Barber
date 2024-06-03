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
    /// Логика взаимодействия для AddingService.xaml
    /// </summary>
    public partial class AddingService : Window
    {
        private database.Services_ _service;
        private DB_BarbershopEntities _context;

        public AddingService()
        {
            InitializeComponent();
            _context = DB_BarbershopEntities.GetContext();
            LoadTypes();
        }

        public AddingService(database.Services_ service)
        {
            InitializeComponent();
            _service = service;
            _context = DB_BarbershopEntities.GetContext();
            LoadTypes();

            NameService.Text = _service.Title;
            PriceService.Text = _service.Price.ToString();
            TypeService.SelectedValue = _service.ID_Type;
        }

        private void LoadTypes()
        {
            TypeService.ItemsSource = _context.Type_services.ToList();
            TypeService.DisplayMemberPath = "Type_";
            TypeService.SelectedValuePath = "ID_Type";
        }

        private void RegistServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_service == null)
            {
                _service = new database.Services_();
                _context.Services_.Add(_service);
            }

            _service.Title = NameService.Text;
            _service.Price = float.Parse(PriceService.Text);
            _service.ID_Type = (int)TypeService.SelectedValue;

            _context.SaveChanges();
            MessageBox.Show("Услуга успешно добавлена/редактирована!");

            var backMainWindow = new Main();
            backMainWindow.Show();
            Close();
        }

        private void BackMain_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Main();
            mainWindow.Show();
            Close();
        }
    }
}