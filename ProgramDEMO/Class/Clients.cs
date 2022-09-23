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
    /// Klasa odwzorowujaca klienta z bazy danych
    /// </summary>
    public class Clients
    {
        #region wlasnosci
        public decimal Id { get; set; }
        public string name { get; set; }
        public string nip { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public decimal nrOfHouse { get; set; }
        public decimal nrOfLocal { get; set; }
        #endregion
        #region metody

        /// <summary>
        /// Metoda służąca do ściągniecia wszystkich rekordów z bazy danych w trakcie uruchomienia programu
        /// </summary>
        /// <param name="recordId"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        /// <param name="t6"></param>
        public void loadDataFromDbToUpdateForm(string recordId, TextBox t1,TextBox t2,
            TextBox t3,TextBox t4, TextBox t5, TextBox t6)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM Klienci WHERE Id = '" + recordId + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    name = sdr.GetSqlString(1).ToString();
                    nip = sdr.GetSqlString(2).ToString();
                    city = sdr.GetSqlString(3).ToString();
                    street = sdr.GetSqlString(4).ToString();
                    nrOfHouse = (decimal)sdr.GetSqlDecimal(5);
                    nrOfLocal = (decimal)sdr.GetSqlDecimal(6);
                }
                t1.Text = name;
                t2.Text = nip;
                t3.Text = city;
                t4.Text = street;
                t5.Text = nrOfHouse.ToString();
                t6.Text = nrOfLocal.ToString();
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
        public void loadDataFromDb(ListView lista)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM Klienci";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);

                SqlDataReader sdr = sda.SelectCommand.ExecuteReader();
                while (sdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(sdr.GetSqlDecimal(0).ToString());//id
                    lvi.SubItems.Add(sdr.GetSqlString(1).ToString());//nazwa
                    lvi.SubItems.Add(sdr.GetSqlString(2).ToString());//nip
                    lvi.SubItems.Add(sdr.GetSqlString(3).ToString());//miejscowosc
                    lvi.SubItems.Add(sdr.GetSqlString(4).ToString());//ulica
                    lvi.SubItems.Add(sdr.GetSqlDecimal(5).ToString());//nr_domu
                    lvi.SubItems.Add(sdr.GetSqlDecimal(6).ToString());//nr_lokalu
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

        public void addNewClient(string nazwa, string nip, string miejscowosc,string ulica, string numer_domu, string numer_lokalu)
        {
            try
            {
                SQLConnection.connectToServer();                  
                string query = "INSERT INTO Klienci ( Nazwa, NIP, Miejsowosc, Ulica, Numer_domu, Numer_lokalu) VALUES ('" + nazwa + "', '" + nip + "', '" + miejscowosc + "', '"+ulica+"', '"+numer_domu+"', '"+numer_lokalu+"' )";
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

        public void editClient(string recordId,string nazwa, string nip, string miejscowosc, string ulica, string numer_domu, string numer_lokalu)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "UPDATE Klienci SET Nazwa ='" + nazwa + "', nip = '" + nip + "', Miejsowosc= '" + miejscowosc + "', Ulica = '"+ulica+"', Numer_domu = '"+numer_domu+"', Numer_lokalu = '"+numer_lokalu+"'  WHERE Id = '" + recordId + "'";
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

        public void deleteClient (string rekordId)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "DELETE FROM Klienci  WHERE Id = '" + rekordId + "'";
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
