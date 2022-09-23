using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuleProgramDEMODocument;
using ProgramDEMO.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramDEMO
{
    public partial class documentForm : Form
    {
        headerClient client;
        headerProduct product;
        public documentForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool checkTheFields(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2, System.Windows.Forms.DateTimePicker d1, System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
        => (string.IsNullOrEmpty(c1.Text) || string.IsNullOrEmpty(c2.Text) || string.IsNullOrEmpty(d1.Text) || string.IsNullOrEmpty(t1.Text) || string.IsNullOrEmpty(t2.Text) || string.IsNullOrEmpty(t3.Text) || string.IsNullOrEmpty(t4.Text));
        private void documentForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            comboBox_typ.Items.Clear();
            comboBox_typ.Items.Add("Faktura");
            comboBox_typ.ResetText();

            txt_sygnatura.Enabled = false;
            txt_sumaPozycji.Enabled = false;
            txt_wartoscPozycji.Enabled = false;
            txt_wartosc.Enabled = false;
            txt_clientID.Enabled = false;

            try
            {
                comboBox_Client.Items.Clear();
                SQLConnection.connectToServer();
                string query = "SELECT NazwaKlienta FROM NaglowekDokumentu ORDER BY NazwaKlienta";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow row1 in dt.Rows)
                {
                    //wczytywanie po kolei wierszy z nazwaklienta
                    comboBox_Client.Items.Add(row1["NazwaKlienta"]);
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
            comboBox_Client.ResetText();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_warttoscPozycji_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!checkTheFields(comboBox_typ, comboBox_Client, dateTimePicker1, txt_nip, txt_produkt, txt_cena, txt_ilosc))
            {
                if (checkProduct(txt_produkt.Text))
                {

                    if (client is null)
                    {

                        client = new headerClient(comboBox_Client.Text, txt_nip.Text, DateTime.Parse(dateTimePicker1.Text), comboBox_typ.Text);
                        product = new headerProduct(client.Signature, txt_produkt.Text, decimal.Parse(txt_cena.Text), decimal.Parse(txt_ilosc.Text), DateTime.Parse(dateTimePicker1.Text), (DocumentType)Enum.Parse(typeof(DocumentType), comboBox_typ.Text));
                        product.AddValue(decimal.Parse(txt_cena.Text), decimal.Parse(txt_ilosc.Text));
                        txt_wartosc.Text = product.Value.ToString();
                        client.CalculateItemsTotal(Decimal.Parse(txt_ilosc.Text));
                        client.CalculateItemsValueTotal(Decimal.Parse(txt_wartosc.Text));
                        AddNewClient(client.Signature, comboBox_Client.Text, txt_nip.Text, client.ItemsTotal, client.ItemsValueTotal, DateTime.Parse(dateTimePicker1.Text), comboBox_typ.Text);
                        client.Id = GetRecordID(txt_nip.Text);
                        client.GenerateSignature(client.Type);
                        txt_sygnatura.Text = client.Signature;
                        UpdatedSignature(client.Id);
                        AddNewProduct(client.Signature, txt_produkt.Text, decimal.Parse(txt_cena.Text), decimal.Parse(txt_ilosc.Text), product.Value, product.Data, product.Type.ToString());
                        txt_wartoscPozycji.Text = client.ItemsValueTotal.ToString();
                        txt_sumaPozycji.Text = client.ItemsTotal.ToString();
                        txt_clientID.Text = client.Id.ToString();
                        txt_nip.Enabled = false;
                        comboBox_Client.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        comboBox_typ.Enabled = false;

                    }
                    else
                    {

                        product = new headerProduct(client.Signature, txt_produkt.Text, decimal.Parse(txt_cena.Text), decimal.Parse(txt_ilosc.Text), DateTime.Parse(dateTimePicker1.Text), (DocumentType)Enum.Parse(typeof(DocumentType), comboBox_typ.Text));
                        product.AddValue(decimal.Parse(txt_cena.Text), decimal.Parse(txt_ilosc.Text));
                        txt_wartosc.Text = product.Value.ToString();
                        AddNewProduct(client.Signature, txt_produkt.Text, decimal.Parse(txt_cena.Text), decimal.Parse(txt_ilosc.Text), product.Value, product.Data, product.Type.ToString());
                        client.CalculateItemsTotal(Decimal.Parse(txt_ilosc.Text));
                        client.CalculateItemsValueTotal(Decimal.Parse(txt_wartosc.Text));
                        txt_wartoscPozycji.Text = client.ItemsValueTotal.ToString();
                        txt_sumaPozycji.Text = client.ItemsTotal.ToString();
                        txt_nip.Enabled = false;
                        comboBox_Client.Enabled = false;
                        dateTimePicker1.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("This product does not exist in database", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete all fields", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdatedSignature(decimal recordID)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "Update NaglowekDokumentu SET Sygnatura = '" + client.Signature + "' where Id='" + recordID + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                cmd.ExecuteNonQuery();

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
        private bool checkProduct(string searchedProduct)
        {
            bool available = false;
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT Nazwa From Produkty";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    if (searchedProduct == sdr.GetSqlString(0).ToString())
                    {
                        available = true;
                    }
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
            return available;
        }
        private decimal GetRecordID(string NIP)
        {
            decimal id = default(decimal);
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT Id FROM NaglowekDokumentu WHERE NIPKlienta = '" + NIP + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    id = (decimal)sdr.GetSqlDecimal(0);
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
            return id;
        }
        private void AddNewProduct(string sygnatura, string produkt, decimal price, decimal quantity, decimal value, DateTime date, string type)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = product.GenerateQueryInsert(sygnatura, produkt, price, quantity, value, date, type);
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("A product record was added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList(listView1, client.Signature);

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
        private void AddNewClient(string syg, string nazwaKlienta, string nip, decimal sumaPozycji, decimal wartoscPozycji, DateTime data, string typ)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = client.GenereteQueryInsert(syg, nazwaKlienta, nip, sumaPozycji, wartoscPozycji, data, typ);
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                sda.SelectCommand.ExecuteNonQuery();
                sda = new SqlDataAdapter(query, SQLConnection.conn);
                MessageBox.Show("A client record was added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void loadDataFromDbToListView(System.Windows.Forms.ListView l, string sig)
        {
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM PozycjeDokumentu WHERE Sygnatura = '" + sig + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(sdr.GetSqlDecimal(0).ToString());
                    lvi.SubItems.Add(sdr.GetSqlString(1).ToString());
                    lvi.SubItems.Add(sdr.GetSqlString(2).ToString());
                    lvi.SubItems.Add(sdr.GetSqlDecimal(3).ToString());
                    lvi.SubItems.Add(sdr.GetSqlDecimal(4).ToString());
                    lvi.SubItems.Add(sdr.GetSqlDecimal(5).ToString());
                    lvi.SubItems.Add(sdr.GetValue(6).ToString());
                    lvi.SubItems.Add(sdr.GetSqlString(7).ToString());
                    l.Items.Add(lvi);
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

        private void RefreshList(System.Windows.Forms.ListView l, string sig)
        {
            listView1.Items.Clear();
            loadDataFromDbToListView(l, sig);
        }

        private void txt_signature_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Client_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //insert data in to the textbox's according to the selected NazwaKlienta
                string selectedItem = comboBox_Client.SelectedItem.ToString();
                SQLConnection.connectToServer();
                string query = "SELECT * FROM NaglowekDokumentu WHERE NazwaKlienta = '" + selectedItem + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                SqlDataReader sdr = sda.SelectCommand.ExecuteReader();

                while (sdr.Read())
                {
                    txt_clientID.Text = sdr.GetSqlDecimal(0).ToString();
                    txt_nip.Text = sdr.GetSqlString(3).ToString();
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
            comboBox_Client.ResetText();

        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_produkt.Clear();
            txt_cena.Clear();
            txt_ilosc.Clear();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (client is not null)
            {
                //utworzenie pliku.txt
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\Faktura_{client.CustomerName}_{client.CustomerNIP}" + ".txt";
                List<string> l = GetListClient(client.Id);
                List<string> l2 = GetListProduct(client.Signature);
                using (FileStream fS = File.Create(filePath))
                {
                    byte[] data, data2;
                    string s1 = $"{"ID",25} |" + $"{"Sygnatura",25} |" + $"{"NazwaKlienta",25} |" + $"{"NIPKlienta",25} |"
                        + $"{"SumaPozycji",25} |" + $"{"WartoscPozycji",25} |" + $"{"Data",25} |" + $"{"Typ",25} |";
                    string s2 = $"{"ID",25} |" + $"{"Sygnatura",25} |" + $"{"Produkt",25} |" + $"{"Cena",25} |"
                        + $"{"Ilość",25} |" + $"{"Wartość",25} |" + $"{"Data",25} |" + $"{"Typ",25} |";

                    data = new UTF8Encoding(true).GetBytes(new String('-', s1.Length) + Environment.NewLine + Environment.NewLine);
                    fS.Write(data, 0, data.Length);

                    data = new UTF8Encoding(true).GetBytes(s1);
                    fS.Write(data, 0, data.Length);

                    data = new UTF8Encoding(true).GetBytes(Environment.NewLine + Environment.NewLine +  Environment.NewLine);
                    fS.Write(data, 0, data.Length);
                    //tworzenie struktury pliku
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (i == l2.Count - 1)
                        {
                            data = new UTF8Encoding(true).GetBytes($"{l[i].ToString() + Environment.NewLine.ToString() ,25}");
                            fS.Write(data, 0, data.Length);
                        }
                        else
                        {
                             data = new UTF8Encoding(true).GetBytes($"{l[i].ToString() + " | ",25}");
                            fS.Write(data, 0, data.Length);
                        }

                    }
                    data = new UTF8Encoding(true).GetBytes(Environment.NewLine + Environment.NewLine + new String('-', s1.Length) + Environment.NewLine + Environment.NewLine);
                    fS.Write(data, 0, data.Length);

                    data2 = new UTF8Encoding(true).GetBytes(s2);
                    fS.Write(data2, 0, data2.Length);

                    data2 = new UTF8Encoding(true).GetBytes(Environment.NewLine + Environment.NewLine + Environment.NewLine);
                    fS.Write(data2, 0, data2.Length);

                    for (int i = 0; i < l2.Count; i++)
                    {
                        if ( (i+1) % 8 == 0 )
                        {
                            data2 = new UTF8Encoding(true).GetBytes($"{l2[i].ToString() + Environment.NewLine.ToString(),25}");
                            fS.Write(data2, 0, data2.Length);
                        }
                        else
                        {
                            data2 = new UTF8Encoding(true).GetBytes($"{l2[i].ToString() + " | ",25}");
                            fS.Write(data2, 0, data2.Length);
                        }
                        
                    }
                    data2 = new UTF8Encoding(true).GetBytes(new String('-', s1.Length) + Environment.NewLine + Environment.NewLine);
                    fS.Write(data2, 0, data2.Length);
                }
                MessageBox.Show("The file has been created", "INFORMATION", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The file has not been created, add the contractor", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private List<string> GetListProduct(string sig)
        {
            List<string> list = new List<string>();
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM PozycjeDokumentu WHERE Sygnatura = '" + sig + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    list?.Add(sdr.GetValue(0).ToString());
                    list?.Add(sdr.GetValue(1).ToString());
                    list?.Add(sdr.GetValue(2).ToString());
                    list?.Add(sdr.GetValue(3).ToString());
                    list?.Add(sdr.GetValue(4).ToString());
                    list?.Add(sdr.GetValue(5).ToString());
                    list?.Add(sdr.GetValue(6).ToString());
                    list?.Add(sdr.GetValue(7).ToString());
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
            return list;
        }
        private List<string> GetListClient(decimal ID)
        {
            List<string> list = new List<string>();
            try
            {
                SQLConnection.connectToServer();
                string query = "SELECT * FROM NaglowekDokumentu WHERE Id = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    list?.Add(sdr.GetValue(0).ToString());
                    list?.Add(sdr.GetValue(1).ToString());
                    list?.Add(sdr.GetValue(2).ToString());
                    list?.Add(sdr.GetValue(3).ToString());
                    list?.Add(sdr.GetValue(4).ToString());
                    list?.Add(sdr.GetValue(5).ToString());
                    list?.Add(sdr.GetValue(6).ToString());
                    list?.Add(sdr.GetValue(7).ToString());
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
            return list;
        }

        private void txt_nip_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex reg = new Regex(@"[0-9]{1,9}");
            if (!reg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("Insert only digits", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex reg = new Regex(@"[0-9]{1,9}");
            if (!reg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("Insert only digits", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ilosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex reg = new Regex(@"[0-9]{1,9}");
            if (!reg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("Insert only digits", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_produkt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_produkt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Insert only letter", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_Client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Insert only letter", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_typ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true; //sluzy do tego, aby przytrzymac text, ktory jest juz wpisany do tej pory bez dodania cyfry, gdy wywola sie ten blok if
                MessageBox.Show("Insert only letter", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
