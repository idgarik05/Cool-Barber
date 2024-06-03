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

namespace WPF_Barbershop.windows
{
    /// <summary>
    /// Логика взаимодействия для AddingBarber.xaml
    /// </summary>
    public partial class AddingBarber : Window
    {
        public AddingBarber()
        {
            InitializeComponent();
        }

        private void BackMain_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Main();
            mainWindow.Show();
            Close();
        }

        private void RegistBarberBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены в правильности заполненных данных?", "", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var connectionString = @"data source=LAPTOP-UF3MFSG3\SQLEXPRESS;initial catalog=DB_Barbershop;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework";

                string lastName = SurnameBox.Text, name = NameBox.Text, patronymic = PatronymicBox.Text, numPhone = PhoneNumberBox.Text;
                string login = LoginBox.Text, password = PasswordBox.Text;

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlConnection.Open();
                        string requestAddBarber = $"insert into Employees (ID_Position, Surname, Name_, Patronymic, Phone_number) values (2,'{lastName}','{name}','{patronymic}','{numPhone}')\r\n" +
                            $"insert into Accounts (ID_Employee, Login_, Password_) values ((select max(ID_Employee) from Employees),'{login}','{password}')";

                        using (SqlCommand command = new SqlCommand(requestAddBarber, sqlConnection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Данные сохранены!");
                        var backmainWindow = new Main();
                        backmainWindow.Show();
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
}