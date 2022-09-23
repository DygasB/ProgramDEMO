using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

//using Library.ProgramDEMO.SQLConnection;


namespace ProgramDEMO.Class
{
    /// <summary>
    /// Klasa odwzorowująca jednostki
    /// </summary>
    public class Units
    {
        #region własności
        //pola tabeli units
        public decimal Id { get; set; }
        public string Name { get; set; }
        public bool Used { get; set; }
        #endregion

        #region metody
        /// <summary>
        /// Metoda służąca do ściągniecia wszystkich rekordów z bazy danych w trakcie uruchomienia programu
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public void loadDataFromDbToUpdateForm(string recordID, TextBox t1, TextBox t2)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT * FROM JednostkiMiar WHERE Id = '"+recordID+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                SqlDataReader sdr = sda.SelectCommand.ExecuteReader();

                while (sdr.Read())
                {
                    Name = sdr.GetSqlString(1).ToString();
                    Used = (bool)sdr.GetSqlBoolean(2);
                }
                t1.Text = Name;
                t2.Text = Used.ToString();
                
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
        public  void loadDataFromDb(ListView listView)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT * FROM JednostkiMiar";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                SqlDataReader sdr = sda.SelectCommand.ExecuteReader();

                while (sdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(sdr.GetSqlDecimal(0).ToString());
                    lvi.SubItems.Add(sdr.GetSqlString(1).ToString()); 
                    lvi.SubItems.Add(sdr.GetSqlBoolean(2).ToString()); 
                    listView.Items.Add(lvi);
                }
                //zamkniecie sqldatareader
                sdr.Close();

            }
            catch(SqlException se)
            {
                MessageBox.Show("ERROR " + se);
            }
            finally
            {
                SQLConnection.conn.Close();
            }
        }
        public  int getLastId()
        {
            int lastId = 0;
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT top 1 FROM JednostkiMiar ORDER BY Id desc";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lastId = (int)sdr.GetSqlDecimal(0);
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
            return lastId;
        }
        public void addNewUnit(string unitName, string unitUsed)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"INSERT INTO JednostkiMiar (Nazwa,Uzyto) VALUES ('"+unitName+"', '"+unitUsed+"')";
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
        public  void getRecordById(string recordId)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT * FROM JednostkiMiar WHERE Id='"+recordId+"'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                cmd.ExecuteNonQuery();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Id = (decimal)sdr.GetSqlDecimal(0);
                    Name = sdr.GetSqlString(1).ToString();
                }
                //Debug.WriteLine($"Id: {Id}; Name: {Name}");
                //sdr nie zapetli sie, poniewaz wczyta tylko jeden rekord, wiec nie trzeba uzywac sdr.Close()

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
        public void getRecordByIdToForm(string recordId, TextBox idTextbox, TextBox nameTextBox)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT * FROM JednostkiMiar Where Id='"+recordId+"'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                cmd.ExecuteNonQuery();
                SqlDataReader sdr = cmd.ExecuteReader();
                
                decimal idFromDb;
                while (sdr.Read())
                {
                    Id = (decimal)sdr.GetSqlDecimal(0);
                    Name = sdr.GetSqlString(1).ToString();
                }
                //Debug.WriteLine($"Id: {Id}; Name: {Name}");
                idTextbox.Text = Id.ToString();
                nameTextBox.Text = Name.ToString();

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

        public void editUnit(string recordId, TextBox nameTextBox, TextBox used)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"UPDATE JednostkiMiar Set nazwa='"+nameTextBox.Text+"' , Uzyto = '"+used.Text+"' WHERE Id ='"+recordId+"'";
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

        public bool checkUsed(string recordId)
        {
            bool usedState = false;
            try
            {
                SQLConnection.connectToServer();
                string query = @"SELECT Uzyto FROM JednostkiMiar WHERE Id='"+recordId+"'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {
                    usedState = (bool)sdr.GetSqlBoolean(0);
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
        public void deleteUnit(string recordId)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = @"DELETE FROM JednostkiMiar WHERE Id='" + recordId + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                
                bool usedState = checkUsed(recordId);
                if(usedState == false)
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
