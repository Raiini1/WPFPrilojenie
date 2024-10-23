using Microsoft.Data.Sqlite;
using System.Data.SQLite;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Uchebnye_kursi;

namespace Uchebnye_kursi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Role;
            string cs = "Data Source=E:\\практика\\практика 4 курс\\УП 03.01\\приложение\\Uchebnye_kursi\\Uchebnye_kursi\\Uchebnye_kursi.db;Version=3;";
            using (SQLiteConnection sqliteCon = new SQLiteConnection(cs))
            {
                sqliteCon.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT Role FROM Avtorizacia WHERE Login = @Login AND Parol = @Parol", sqliteCon);
                command.Parameters.AddWithValue("@Login", TextboxLogin.Text);
                command.Parameters.AddWithValue("@Parol", PasswordBoxParol.Password);
                Role = (string)command.ExecuteScalar();
            }
            if (Role == "Администратор")
            {
                this.Hide();
                Kursi f3 = new Kursi();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
