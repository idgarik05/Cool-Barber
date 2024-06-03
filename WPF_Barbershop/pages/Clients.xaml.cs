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
using System.Xml.Linq;
using WPF_Barbershop.database;
using WPF_Barbershop.windows;

namespace WPF_Barbershop.pages
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Page
    {

        DataTable dataTable;
        string connectionString = @"data source=LAPTOP-UF3MFSG3\SQLEXPRESS;initial catalog=DB_Barbershop;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework";
        public Clients()
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataTable.Columns.Add("Фамилия", typeof(string));
            dataTable.Columns.Add("Имя", typeof(string));
            dataTable.Columns.Add("Отчество", typeof(string));
            dataTable.Columns.Add("Номер телефона", typeof(string));

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string queryClient = "SELECT Surname, Name_, Patronymic, Phone_number FROM Clients";
                SqlCommand command = new SqlCommand(queryClient, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string lastName = reader.GetString(0);
                    string name = reader.GetString(1);
                    string patronymic = reader.GetString(2);
                    string phoneNumber = reader.GetString(3);

                    dataTable.Rows.Add(lastName, name, patronymic, phoneNumber);
                }
                reader.Close();
                sqlConnection.Close();
                DG_Clients.ItemsSource = dataTable.DefaultView;
            }
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            var addBarberWindow = new AddingClient();
            addBarberWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void Search_Client_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = Search_Client.Text.ToLower();
            dataTable.DefaultView.RowFilter = string.Empty;
            if (!string.IsNullOrEmpty(search))
            {
                string filter = $"Фамилия LIKE '%{search}%' OR Имя LIKE '%{search}%' OR Отчество LIKE '%{search}%'";
                dataTable.DefaultView.RowFilter = filter;
            }
        }
    }
}