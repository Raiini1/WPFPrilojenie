using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

namespace Uchebnye_kursi
{
    /// <summary>
    /// Логика взаимодействия для Sotrudniki.xaml
    /// </summary>
    public partial class Sotrudniki : Window
    {
        private string connectionString = "Data Source=D:\\ПАПКИ\\кмк\\Практика\\практика 4 курс\\УП 03.01\\приложение\\Uchebnye_kursi.db;Version=3;";
        public Sotrudniki()
        {
            InitializeComponent();
            LoadSotrudData();
        }
        private void LoadSotrudData()
        {
            List<Sotrudnik> courses = new List<Sotrudnik>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_Sotrudnik, Familia, Imya, Tsena_kursa, Otchestvo, " +
                               "Doljnost.Nazvanie_doljnosti AS Doljnost_ID, " +
                               "Data_rojdenia, Adres_projivania FROM Sotrudnik " +
                               "JOIN Doljnost ON Sotrudnik.Doljnost_ID = Doljnost.ID_Doljnost";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sotrudnik sotrud = new Sotrudnik
                        {
                            ID_Sotrudnik = reader["ID_Sotrudnik"].ToString(),
                            Familia = reader["Familia"].ToString(),
                            Imya = reader["Imya"].ToString(),
                            Otchestvo = reader["Otchestvo"].ToString(),
                            Doljnost_ID = reader["Doljnost_ID"].ToString(),
                            Data_rojdenia = reader["Data_rojdenia"].ToString(),
                            Adres_projivania = reader["Adres_projivania"].ToString()
                        };
                        courses.Add(sotrud);
                    }
                }
            }
            DataGridSotrud.ItemsSource = courses;
        }
    }
    public class Sotrudnik
    {
        public string ID_Sotrudnik { get; set; }
        public string Familia { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public string Doljnost_ID { get; set; }
        public string Data_rojdenia { get; set; }
        public string Adres_projivania { get; set; }
    }
}