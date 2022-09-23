using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Library.ProgramDEMO.SQLConnection;


namespace ProgramDEMO.Class
{
    public static class SQLConnection
    {
        #region własności

        //deklaracja parametrow polaczenia do bazy danych
        public static string serverAddress { get; set; }
        public static string databaseName { get; set; }
        public static string user_login { get; set; }
        public static string user_password { get; set; }

        //deklaracja sciezki do folderu AppData
        public static string pathAppdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //deklaracja konkretnej sciezki do pliku w folderze AppData
        public static string pathFolder = Path.Combine(pathAppdata, @"Program_demo");
        //deklaracja sciezki do folderu aplikacji w folderze AppData
        public static string pathFile = Path.Combine(pathFolder, @"conn.txt");

        //deklaracja zmiennych sluzacych do polaczenia z baza danych
        //public static string connectionString { get; set; }
        public static SqlConnection conn { get; set; }

        #endregion

        #region metody

        //metoda inicjalizujaca parametry polaczenia do bazy danych
        public static void parametersInit()
        {

            downloadConfigurationFromFile();
            databaseName = "ProgramDEMO";

        }
        //metoda tworzaca connectionString
        public static void createConnectionString()
        {
            parametersInit();
            Connection.setConnectionString(serverAddress,databaseName,user_login,user_password);

        }
        public static void checkParameters()
        {
            try
            {
                createConnectionString();
                conn = new SqlConnection(Connection.connectionString);
                conn.Open();
                MessageBox.Show("The connection is ok", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void connectToServer()
        {
            try
            {
                createConnectionString();
                conn = new SqlConnection(Connection.connectionString);
                conn.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //metoda pobierajaca dane z pliku do zmiennych
        private static void downloadConfigurationFromFile()
        {
            if (Directory.Exists(pathFolder))
            {
                //odczytanie pliku z konfiguracja polaczenia do serwera SQL
                using (StreamReader sr = new StreamReader(pathFile, Encoding.Default))
                {
                    //Wskazanie wartości z pliku
                    string text = sr.ReadToEnd();
                    //Podział wartości poprzez separator (;)
                    string[] s_text = text.Split(";");
                    //Przypisanie poszczególnych danych z pliku do zmiennych dla parametrów

                    serverAddress = s_text[0];
                    user_login = s_text[1];
                    user_password = s_text[2];
                }
            }

        }
        #endregion

    }
}
