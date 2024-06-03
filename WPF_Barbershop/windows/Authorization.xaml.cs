using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using WPF_Barbershop.classes;
using WPF_Barbershop.database;

namespace WPF_Barbershop.windows
{
    public partial class Authorization : Window
    {
        private string connectionString = @"data source=LAPTOP-UF3MFSG3\SQLEXPRESS;initial catalog=DB_Barbershop;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection _connection;
        private DB_BarbershopEntities _context;
        public Authorization()
        {
            InitializeComponent();
            _connection = new SqlConnection(connectionString);
            _context = new DB_BarbershopEntities();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Login_Box.Text.Length == 0)
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (PasswordB.Password.Length == 0)
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            bool foundUser = false;
            string login = Login_Box.Text;
            string password = PasswordB.Password;

            string queryAdmin = "SELECT * FROM Accounts " +
                                "INNER JOIN Employees ON Employees.ID_Employee = Accounts.ID_Employee " +
                                "INNER JOIN Positions ON Positions.ID_Position = Employees.ID_Position " +
                                "WHERE Positions.Position = 'Администратор' AND Login_ = @Login AND Password_ = @Password";
            string queryBarber = "SELECT Employees.Surname, Employees.Name_, Employees.Patronymic " +
                                 "FROM Accounts " +
                                 "INNER JOIN Employees ON Employees.ID_Employee = Accounts.ID_Employee " +
                                 "INNER JOIN Positions ON Positions.ID_Position = Employees.ID_Position " +
                                 "WHERE Positions.Position = 'Барбер' AND Login_ = @Login AND Password_ = @Password";

            DataTable dt_admin = SelectWithParameters(queryAdmin, login, password);
            if (dt_admin.Rows.Count > 0)
            {
                LogPas.Log = login;
                LogPas.Pas = password;
                var mainWindow = new Main();
                mainWindow.Show();
                Close();
                foundUser = true;
            }

            DataTable dt_barber = SelectWithParameters(queryBarber, login, password);
            if (dt_barber.Rows.Count > 0)
            {
                LogPas.Log = login;
                LogPas.Pas = password;
                Barber.Surname = dt_barber.Rows[0]["Surname"].ToString();
                Barber.Name = dt_barber.Rows[0]["Name_"].ToString();
                Barber.Patronymic = dt_barber.Rows[0]["Patronymic"].ToString();

                var barber = _context.Accounts.Where(a => a.Login_ == login && a.Password_ == password && a.Employees.Positions.Position == "Барбер").Select(a => a.Employees).FirstOrDefault();

                var recordWindow = new RecordBarber(barber);
                recordWindow.Show();
                Close();
                foundUser = true;
            }

            if (!foundUser)
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private DataTable SelectWithParameters(string selectSQL, string login, string password)
        {
            DataTable dataTable = new DataTable("dataBase");
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(selectSQL, _connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);
            }
            finally
            {
                _connection.Close();
            }

            return dataTable;
        }

        private void showPasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = PasswordB.Password;
            PasswordB.Visibility = Visibility.Collapsed;
            PasswordTextBox.Visibility = Visibility.Visible;
        }

        private void showPasswordCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordB.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Collapsed;
        }
    }
}