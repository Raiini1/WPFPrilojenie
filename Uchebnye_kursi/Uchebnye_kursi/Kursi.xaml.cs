using System;
using System.Data.SQLite;
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
using Uchebnye_kursi;

namespace Uchebnye_kursi
{
    /// <summary>
    /// Логика взаимодействия для Kursi.xaml
    /// </summary>
    public partial class Kursi : Window
    {
        private string connectionString = "Data Source=E:\\практика\\практика 4 курс\\УП 03.01\\приложение\\Uchebnye_kursi\\Uchebnye_kursi\\Uchebnye_kursi.db;Version=3;";
        public Kursi()
        {
            InitializeComponent();
            LoadKursData();
        }
        private void LoadKursData()
        {
            List<Kurs> courses = new List<Kurs>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_Kurs, Nazvanie_kursa, Prodoljitelnost_kursa, Tsena_kursa, Kolvo_mest, " +
                               "CONCAT(Sotrudnik.Familia, ' ', Sotrudnik.Imya, ' ', Sotrudnik.Otchestvo) AS Sotrudnik_FIO, " +
                               "Skidka, Tsena_so_skidkoi, Data_nachala, Data_okonchania, Status_oplati " +
                               "FROM Kurs " +
                               "JOIN Sotrudnik ON Kurs.Sotrudnik_ID = Sotrudnik.ID_Sotrudnik";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kurs kurs = new Kurs
                        {
                            ID_Kurs = reader["ID_Kurs"].ToString(),
                            Nazvanie_kursa = reader["Nazvanie_kursa"].ToString(),
                            Prodoljitelnost_kursa = reader["Prodoljitelnost_kursa"].ToString(),
                            Tsena_kursa = reader["Tsena_kursa"].ToString(),
                            Kolvo_mest = reader["Kolvo_mest"].ToString(),
                            Sotrudnik_FIO = reader["Sotrudnik_FIO"].ToString(),
                            Skidka = reader["Skidka"].ToString(),
                            Tsena_so_skidkoi = reader["Tsena_so_skidkoi"].ToString(),
                            Data_nachala = reader["Data_nachala"].ToString(),
                            Data_okonchania = reader["Data_okonchania"].ToString(),
                            Status_oplati = reader["Status_oplati"].ToString()
                        };
                        courses.Add(kurs);
                    }
                }
            }
            DataGridKurs.ItemsSource = courses;
        }
    }

    public class Kurs
    {
        public string ID_Kurs { get; set; }
        public string Nazvanie_kursa { get; set; }
        public string Prodoljitelnost_kursa { get; set; }
        public string Tsena_kursa { get; set; }
        public string Kolvo_mest { get; set; }
        public string Sotrudnik_FIO { get; set; }
        public string Skidka { get; set; }
        public string Tsena_so_skidkoi { get; set; }
        public string Data_nachala { get; set; }
        public string Data_okonchania { get; set; }
        public string Status_oplati { get; set; }
    }
}
   
