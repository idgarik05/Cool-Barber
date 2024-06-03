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
    /// Логика взаимодействия для Barbers.xaml
    /// </summary>
    public partial class Barbers : Page
    {
        DataTable dataTable;
        string connectionString = @"data source=LAPTOP-UF3MFSG3\SQLEXPRESS;initial catalog=DB_Barbershop;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework";
        public Barbers()
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
                string queryClient = "SELECT Surname, Name_, Patronymic, Phone_number FROM Employees";
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
                DG_Barbers.ItemsSource = dataTable.DefaultView;
            }
        }

        private void AddBarberBtn_Click(object sender, RoutedEventArgs e)
        {
            var addBarberWindow = new AddingBarber();
            addBarberWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void DeleteBarberBtn_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = DG_Barbers.SelectedItem as DataRowView;

            if (selectedRow == null)
            {
                MessageBox.Show("Необходимо выбрать строку, чтобы удалить");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить строку?", "Удалить вопрос", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                    string lastName = selectedRow["Фамилия"] as string;
                    string name = selectedRow["Имя"] as string;
                    string patronymic = selectedRow["Отчество"] as string;
                    string phoneNumber = selectedRow["Номер телефона"] as string;

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                     sqlConnection.Open();
                     string deleteAccountsQuery = "DELETE FROM Accounts WHERE ID_Employee IN (SELECT ID_Employee FROM Employees WHERE Surname = @Surname AND Name_ = @Name AND Patronymic = @Patronymic AND Phone_number = @PhoneNumber)";
                     SqlCommand accountsCommand = new SqlCommand(deleteAccountsQuery, sqlConnection);
                     accountsCommand.Parameters.AddWithValue("@Surname", lastName);
                     accountsCommand.Parameters.AddWithValue("@Name", name);
                     accountsCommand.Parameters.AddWithValue("@Patronymic", patronymic);
                     accountsCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                     accountsCommand.ExecuteNonQuery();

                     string deleteQuery = "DELETE FROM Employees WHERE Surname = @Surname AND Name_ = @Name AND Patronymic = @Patronymic AND Phone_number = @PhoneNumber";
                     SqlCommand command = new SqlCommand(deleteQuery, sqlConnection);
                     command.Parameters.AddWithValue("@Surname", lastName);
                     command.Parameters.AddWithValue("@Name", name);
                     command.Parameters.AddWithValue("@Patronymic", patronymic);
                     command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int rowsAffected = command.ExecuteNonQuery();
                     if (rowsAffected > 0)
                     {
                        MessageBox.Show("Строка удалена!");
                        dataTable.Rows.Remove(selectedRow.Row);
                     }
                        else
                            MessageBox.Show("Ошибка при удалении строки. Возможно, строка не найдена.");
                }
            }
        }

        private void Search_Barber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = Search_Barber.Text.ToLower();
            dataTable.DefaultView.RowFilter = string.Empty;
            if (!string.IsNullOrEmpty(search))
            {
                string filter = $"Фамилия LIKE '%{search}%' OR Имя LIKE '%{search}%' OR Отчество LIKE '%{search}%'";
                dataTable.DefaultView.RowFilter = filter;
            }
        }
    }
}