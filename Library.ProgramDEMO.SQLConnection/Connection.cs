using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Diagnostics;

namespace Library.ProgramDEMO.SQLConnection
{
    /// <summary>
    /// Klasa odpowiedzialna za ustawienie i stworzenie connection string
    /// </summary>
    public static class Connection
    {
        //dependency injection - wstrzykiwanie zależności 
        public static string connectionString { get; set; }
        /// <summary>
        /// Metoda odpowiedzialna za stworzenie connection string
        /// </summary>
        /// <param name="serverAddress"></param>
        /// <param name="databaseName"></param>
        /// <param name="userLogin"></param>
        /// <param name="userPassword"></param>
        public static void setConnectionString( string serverAddress, string databaseName, string userLogin, string userPassword)
        {
            connectionString = @"Data Source=" + serverAddress + ";" + "Initial Catalog=" + databaseName + ";" + "User ID=" + userLogin + ";" + "Password=" + userPassword + ";";
        }
        
    }
}

