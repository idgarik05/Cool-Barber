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
using System.Xml.Linq;
using WPF_Barbershop.database;
using WPF_Barbershop.pages;

namespace WPF_Barbershop.windows
{
    public partial class AddingRecord : Window
    {
        private DB_BarbershopEntities _context;
        private List<int> _selectedServices = new List<int>();
        private double _totalPrice;
        private database.Records _record;

        public AddingRecord()
        {
            InitializeComponent();
            _context = DB_BarbershopEntities.GetContext();
            LoadData();
        }

        public AddingRecord(database.Records record)
        {
            InitializeComponent();
            _context = DB_BarbershopEntities.GetContext();
            _record = record;

            LoadData();

            ClientSurnameBox.Text = _record.Clients.Surname;
            ClientNameBox.Text = _record.Clients.Name_;
            ClientPatronymicBox.Text = _record.Clients.Patronymic;
            ClientPhoneBox.Text = _record.Clients.Phone_number;

            BarberSurnameBox.Text = _record.Employees.Surname;
            BarberNameBox.Text = _record.Employees.Name_;
            BarberPatronymicBox.Text = _record.Employees.Patronymic;

            DatePicker.SelectedDate = _record.Date_;
            TimeComboBox.Text = _record.Time_.ToString(@"hh\:mm");

            foreach (var service in _record.Service_records)
            {
                ServiceListBox.SelectedItems.Add(service.Services_);
                _selectedServices.Add(service.ID_Service);
                _totalPrice += service.Services_.Price;
            }

            UpdateTotalPrice();
        }

        private void LoadData()
        {
            ServiceListBox.ItemsSource = _context.Services_.ToList();
            StockComboBox.ItemsSource = _context.Stocks.Where(s => s.End_date_ >= DateTime.Today).ToList();
        }

        private void AddServiceButton_Click(object sender, RoutedEventArgs e)
        {
            _selectedServices.Clear();
            _totalPrice = 0;

            foreach (var item in ServiceListBox.SelectedItems)
            {
                var service = item as Services_;
                if (service != null)
                {
                    _selectedServices.Add(service.ID_Service);
                    _totalPrice += service.Price;
                }
            }

            UpdateTotalPrice();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string clientSurname = ClientSurnameBox.Text;
            string clientName = ClientNameBox.Text;
            string clientPatronymic = ClientPatronymicBox.Text;
            string clientPhone = ClientPhoneBox.Text;

            string barberSurname = BarberSurnameBox.Text;
            string barberName = BarberNameBox.Text;
            string barberPatronymic = BarberPatronymicBox.Text;

            DateTime? selectedDate = DatePicker.SelectedDate;
            TimeSpan selectedTime = TimeSpan.Parse((string)(TimeComboBox.SelectedItem as ComboBoxItem).Content);

            if (selectedDate == null)
            {
                MessageBox.Show("Выберите дату записи.");
                return;
            }

            int employeeId;

            if (_record == null)
            {
                Employees barber = _context.Employees.FirstOrDefault(b => b.Surname == barberSurname && b.Name_ == barberName && b.Patronymic == barberPatronymic);
                if (barber == null)
                {
                    MessageBox.Show("Барбер не найден.");
                    return;
                }
                employeeId = barber.ID_Employee;
            }
            else
            {
                employeeId = _record.ID_Employee;
            }

            database.Clients client = _context.Clients.FirstOrDefault(c => c.Surname == clientSurname && c.Name_ == clientName && c.Patronymic == clientPatronymic);
            if (client == null)
            {
                client = new database.Clients { Surname = clientSurname, Name_ = clientName, Patronymic = clientPatronymic, Phone_number = clientPhone };
                _context.Clients.Add(client);
                _context.SaveChanges();
            }
            else
            {
                client.Phone_number = clientPhone;
            }

            var conflictingRecord = _record == null
                ? _context.Records.FirstOrDefault(r => r.ID_Employee == employeeId && r.Date_ == selectedDate.Value && r.Time_ == selectedTime)
                : _context.Records.FirstOrDefault(r => r.ID_Employee == employeeId && r.Date_ == selectedDate.Value && r.Time_ == selectedTime && r.ID_Record != _record.ID_Record);

            if (conflictingRecord != null)
            {
                MessageBox.Show("Указанная дата и время уже заняты для данного барбера. Выберите другую дату и время!");
                return;
            }

            if (_record == null)
            {
                _record = new database.Records { ID_Client = client.ID_Client, ID_Employee = employeeId, Date_ = selectedDate.Value, Time_ = selectedTime };
                _context.Records.Add(_record);
            }
            else
            {
                _record.ID_Client = client.ID_Client;
                _record.ID_Employee = employeeId;
                _record.Date_ = selectedDate.Value;
                _record.Time_ = selectedTime;

                _context.Service_records.RemoveRange(_record.Service_records);
            }

            foreach (var serviceId in _selectedServices)
            {
                var stock = (database.Stocks)StockComboBox.SelectedItem;
                double cost = _context.Services_.Find(serviceId).Price;

                if (stock != null)
                {
                    cost = cost - (cost * stock.Discount_size ?? 0 / 100);
                }

                var serviceRecord = new Service_records { ID_Record = _record.ID_Record, ID_Service = serviceId, ID_Stock = stock?.ID_Stock, Cost = cost };
                _record.Service_records.Add(serviceRecord);
            }

            _context.SaveChanges();
            MessageBox.Show("Запись успешно сохранена!");
            var backMainWindow = new Main();
            backMainWindow.Show();
            Close();
        }


        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            var backMainWindow = new Main();
            backMainWindow.Show();
            Close();
        }

        private void UpdateTotalPrice()
        {
            TotalPriceTextBlock.Text = _totalPrice.ToString("F2");
        }
    }
}