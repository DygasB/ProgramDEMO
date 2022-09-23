using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
//using Library.ProgramDEMO.SQLConnection;

namespace ProgramDEMO.Class
{
    /// <summary>
    /// Klasa odwzorowujaca rekordy z bazy danych
    /// </summary>
    public class Products
    {
        #region własności
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string shortcutName { get; set; }
        public string Type { get; set; }
        #endregion

        #region metody

        /// <summary>
        /// Metoda służąca do ściągniecia wszystkich rekordów z bazy danych w trakcie uruchomienia programu
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        public void loadDataFromDbToUpdateForm(string recordID, TextBox t1, TextBox t2, TextBox t3)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM Produkty WHERE Id = '"+recordID+"'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Name = sdr.GetSqlString(1).ToString();
                    shortcutName = sdr.GetSqlString(2).ToString();
                    Type = sdr.GetSqlString(3).ToString();
                }
                sdr.Close();
                t1.Text = Name;
                t2.Text = shortcutName;
                t3.Text = Type;

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
        public void loadDataFromDb(ListView lista)
        {
            try
            {
            SQLConnection.connectToServer();
            string query = "SELECT * FROM Produkty";
            SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);

            SqlDataReader sdr = sda.SelectCommand.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(sdr.GetSqlDecimal(0).ToString());
                lvi.SubItems.Add(sdr.GetSqlString(1).ToString());
                lvi.SubItems.Add(sdr.GetSqlString(2).ToString());
                lvi.SubItems.Add(sdr.GetSqlString(3).ToString());
                lista.Items.Add(lvi);
            }
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
        public void addNewProduct(string nazwa, string skrot_nazwy, string typ)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "INSERT INTO Produkty (Nazwa, Skrot_nazwy, Typ) VALUES ('"+nazwa+ "', '"+skrot_nazwy+ "', '"+typ+"' )";
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
        public void editProduct(string recordId, string nazwa, string skrot_nazwy, string typ)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "UPDATE Produkty SET Nazwa ='" + nazwa + "', Skrot_nazwy = '" + skrot_nazwy + "', Typ= '" + typ + "'  WHERE Id = '"+recordId+"'";
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
        public void deleteProduct(string rekordId)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "DELETE FROM Produkty  WHERE Id = '" + rekordId + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("A record was delted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
