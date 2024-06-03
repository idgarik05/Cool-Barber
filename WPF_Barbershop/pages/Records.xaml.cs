using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_Barbershop.pages
{
    public partial class Records : Page
    {
        DataTable dataTable;
        string connectionString = @"data source=LAPTOP-UF3MFSG3\SQLEXPRESS;initial catalog=DB_Barbershop;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework";

        public Records()
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataTable.Columns.Add("Номер записи", typeof(int));
            dataTable.Columns.Add("Барбер", typeof(string));
            dataTable.Columns.Add("Клиент", typeof(string));
            dataTable.Columns.Add("Дата", typeof(string));
            dataTable.Columns.Add("Время", typeof(string));
            LoadDataIntoDataTable();
        }

        private void LoadDataIntoDataTable()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string queryRecords = "SELECT Records.ID_Record, CONCAT(Employees.Surname, ' ', LEFT(Employees.Name_, 1), '.', LEFT(Employees.Patronymic, 1), '') AS EmployeeName, CONCAT(Clients.Surname, ' ', LEFT(Clients.Name_, 1), '.', LEFT(Clients.Patronymic, 1), '') AS ClientSurname, Date_, CONVERT(nvarchar(5), Time_, 108) AS Time_ FROM Records INNER JOIN Employees ON Employees.ID_Employee = Records.ID_Employee INNER JOIN Clients ON Clients.ID_Client = Records.ID_Client";
                SqlCommand command = new SqlCommand(queryRecords, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idRecord = reader.GetInt32(0);
                    string barber = reader.GetString(1);
                    string client = reader.GetString(2);
                    DateTime date = reader.GetDateTime(3);
                    string time = reader.GetString(4);

                    dataTable.Rows.Add(idRecord, barber, client, date.ToString("dd.MM.yyyy"), time);
                }
                reader.Close();
                sqlConnection.Close();
            }
            DG_Records.ItemsSource = dataTable.DefaultView;
        }

        private void AddRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            var addRecordWindow = new AddingRecord();
            addRecordWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void DeleteRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = DG_Records.SelectedItem as DataRowView;

            if (selectedRow == null)
            {
                MessageBox.Show("Необходимо выбрать строку, чтобы удалить");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                int idRecord = (int)selectedRow["Номер записи"];

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string deleteServiceRecordsQuery = "DELETE FROM Service_records WHERE ID_Record = @ID_Record";
                    SqlCommand deleteServiceRecordsCommand = new SqlCommand(deleteServiceRecordsQuery, sqlConnection);
                    deleteServiceRecordsCommand.Parameters.AddWithValue("@ID_Record", idRecord);
                    deleteServiceRecordsCommand.ExecuteNonQuery();

                    string deleteQuery = "DELETE FROM Records WHERE ID_Record = @ID_Record";
                    SqlCommand command = new SqlCommand(deleteQuery, sqlConnection);
                    command.Parameters.AddWithValue("@ID_Record", idRecord);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запись успешно удалена!");
                        dataTable.Rows.Remove(selectedRow.Row);
                    }
                    else
                        MessageBox.Show("Ошибка при удалении записи.");
                }
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var addRecordWindow = new AddingRecord();
            addRecordWindow.Show();
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
    }
}