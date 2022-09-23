using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ProgramDEMO.Class;
//using Library.ProgramDEMO.SQLConnection;

namespace ProgramDEMO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void check_show_CheckedChanged(object sender, EventArgs e)
        {
            if(check_show.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
        private void startingOff(Control b)
        {
            panel2.Width = b.Width;
            panel2.Left = b.Left;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            startingOff(btn_clear);
            txt_login.Clear();
            txt_password.Clear();
            txt_login.Focus();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            startingOff(btn_exit);
            DialogResult tmp = MessageBox.Show("Do you want to close the program?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tmp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_login.Text.Length > 10)
            {
                txt_login.ForeColor = Color.Green;
            }
            else
            {
                txt_login.ForeColor = Color.Black;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_login.Text.Length > 10) 
            {
                txt_password.ForeColor = Color.Green;
            }
            else
            {
                txt_password.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            startingOff(btn_check);
            //sprawdzenie czy zadeklarowany folder istnieje
            //dane z pliku zostan¹ zaczytane do formularza
            
            if (!Directory.Exists(SQLConnection.pathFolder))
            {
                ConfigurationForm cf = new ConfigurationForm();
                cf.Show();
            }
            else
            {
                MessageBox.Show("Folder exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            startingOff(btn_log_in);

            if (Directory.Exists(SQLConnection.pathFolder))
            {
                try
                {
                    bool loggedIn = false ;
                    SQLConnection.connectToServer();
                    string query = "SELECT * FROM Operatorzy where Nazwa = '" + txt_login.Text + "' AND Haslo = '" + txt_password.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, SQLConnection.conn);
                    
                    SqlDataReader sdr = sda.SelectCommand.ExecuteReader();
                    while (sdr.Read())
                    {
                        loggedIn = (bool)sdr.GetSqlBoolean(3);
                    }
                    sdr.Close();
                    
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    SQLConnection.conn.Close();

                    if (dt.Rows.Count > 0 )
                    {
                        if (loggedIn != true) { 
                        SQLConnection.connectToServer();
                        string q = "UPDATE Operatorzy SET Zalogowany='" + 1 + "' WHERE Nazwa = '" + txt_login.Text + "' and Haslo = '" + txt_password.Text + "'";
                        SqlCommand cmd = new SqlCommand(q, SQLConnection.conn);
                        cmd.ExecuteNonQuery();
                        SQLConnection.conn.Close();

                        MainForm mf = new MainForm();
                        mf.Show();
                        }
                        else
                        {
                            MessageBox.Show("This user is now logged in", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This user doesn't exist", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }
                
                
            }
            else
            {
                MessageBox.Show("Please, set connection, and try againt", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Should I log out a user?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    SQLConnection.connectToServer();
                    string query = "UPDATE Operatorzy SET Zalogowany = '" + 0 + "' WHERE Nazwa = '" + txt_login.Text + "' AND Haslo = '" + txt_password.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, SQLConnection.conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }
                finally
                {
                    SQLConnection.conn.Close();
                    Application.Exit();

                }
            }
            else
            {
                Environment.Exit(0);
            }
            
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}