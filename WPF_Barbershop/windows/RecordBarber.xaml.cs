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
using System.Windows.Shapes;
using WPF_Barbershop.classes;
using WPF_Barbershop.database;
using WPF_Barbershop.pages;

namespace WPF_Barbershop.windows
{
    public partial class RecordBarber : Window
    {
        private Employees _barber;
        private string _connectionString = @"data source=LAPTOP-UF3MFSG3\SQLEXPRESS;initial catalog=DB_Barbershop;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework";
        private List<RecordViewModel> _allRecords;

        public RecordBarber(Employees barber)
        {
            InitializeComponent();
            _barber = barber;
            Barber_name.Content = $"{_barber.Surname} {_barber.Name_} {_barber.Patronymic}";
            LoadRecords(); // Ensure records are loaded when window is initialized
        }

        private void LoadRecords()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            c.Surname,
                            r.Date_,
                            r.Time_
                        FROM 
                            Records r 
                        JOIN 
                            Clients c ON r.ID_Client = c.ID_Client 
                        WHERE 
                            r.ID_Employee = @BarberId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BarberId", _barber.ID_Employee);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    _allRecords = (from DataRow row in table.Rows
                                   select new RecordViewModel
                                   {
                                       Surname = $"{row["Surname"]}",
                                       Date_ = (DateTime)row["Date_"],
                                       Time_ = (TimeSpan)row["Time_"]
                                   }).ToList();

                    DG_RecordsBarber.ItemsSource = _allRecords;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при загрузке записей: {ex.Message}");
            }
        }

        private void DateFilter_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilter();
        }

        //private void FilterBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    ApplyFilter();
        //}

        private void ClearFilterBtn_Click(object sender, RoutedEventArgs e)
        {
            DateFilter.SelectedDate = null;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_allRecords == null)
            {
                LoadRecords();
            }

            DateTime? selectedDate = DateFilter.SelectedDate;
            if (selectedDate.HasValue)
            {
                DG_RecordsBarber.ItemsSource = _allRecords.Where(r => r.Date_ == selectedDate.Value).ToList();
            }
            else
            {
                DG_RecordsBarber.ItemsSource = _allRecords;
            }
        }

        public class RecordViewModel
        {
            public string Surname { get; set; }
            public DateTime Date_ { get; set; }
            public TimeSpan Time_ { get; set; }
        }
    }
}