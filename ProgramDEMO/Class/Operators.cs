using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Library.ProgramDEMO.SQLConnection;

namespace ProgramDEMO.Class
{

    /// <summary>
    /// Klasa odwzorowująca operatora w bazie danych
    /// </summary>
    public class Operators
    {
        #region własności
        public decimal Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public bool loggedIn { get; set; }
        #endregion

        #region metody
        public void loggedOutOperator(string recordID){
            try
            {
                SQLConnection.connectToServer();
                string query = "Update Operatorzy set zalogowany = '"+0+"' WHERE Id = '" + recordID + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                sda.SelectCommand.ExecuteNonQuery();

            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        public void loggedInOperator(string recordID)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "Update Operatorzy set zalogowany = '" + 1 + "' WHERE Id = '" + recordID + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                sda.SelectCommand.ExecuteNonQuery();

            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        /// <summary>
        /// Metoda służąca do ściągniecia wszystkich rekordów z bazy danych w trakcie uruchomienia programu
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        public void loadDataFromDbToUpdateForm(string recordID ,TextBox t1, TextBox t2, TextBox t3)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM Operatorzy WHERE Id = '" + recordID + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query,SQLConnection.conn);
                SqlDataReader sdr = sda.SelectCommand.ExecuteReader();
                while (sdr.Read())
                {
                    name = sdr.GetSqlString(1).ToString();
                    password = sdr.GetSqlString(2).ToString();
                    loggedIn = (bool)sdr.GetSqlBoolean(3);
                }
                sdr.Close();
                t1.Text = name;
                t2.Text= password;
                t3.Text = loggedIn.ToString();

            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        public void loadDataFromDb(ListView listView)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT * FROM Operatorzy";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                SqlDataReader sdr = sda.SelectCommand.ExecuteReader();

                while (sdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(sdr.GetSqlDecimal(0).ToString());
                    lvi.SubItems.Add(sdr.GetSqlString(1).ToString());
                    lvi.SubItems.Add(sdr.GetSqlString(2).ToString());
                    lvi.SubItems.Add(sdr.GetSqlBoolean(3).ToString());
                    listView.Items.Add(lvi);
                }
                //zamkniecie sqldatareader
                sdr.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        public void addNewOperator(string name, string password, string loggedIn)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"INSERT INTO Operatorzy (Nazwa,Haslo, Zalogowany) VALUES ('" + name + "', '" + password + "' , '"+loggedIn+"')";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A record was added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        public void editOperator(string recordId, string name, string password, string loggedIn)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"UPDATE Operatorzy Set Nazwa='" + name + "' , Haslo = '" + password + "', Zalogowany = '"+ loggedIn + "' WHERE Id ='" + recordId + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A record was updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }


        public bool checkLoggedIn(string recordId)
        {
            bool usedState = false;
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT Zalogowany FROM Operatorzy WHERE Id='" + recordId + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    usedState = (bool)sdr.GetSqlBoolean(0); // nie ma funkcji ToBool()
                }


            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
            return usedState;
        }

        public void deleteOperator(string recordId)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"DELETE FROM Operatorzy WHERE Id='" + recordId + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);

                bool usedState = checkLoggedIn(recordId);
                if (usedState == false)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("A record was delted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("I cannot delete units when its being used", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        #endregion
    }
}
