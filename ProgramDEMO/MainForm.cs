using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProgramDEMO.Class;
//using Library.ProgramDEMO.SQLConnection;

namespace ProgramDEMO
{
    public partial class MainForm : Form
    {
        //private unitsForm uF = new unitsForm();
        //private productsForm pF = new productsForm();
        //private clientsForm cF= new clientsForm();
        //private OperatorsForm oF = new OperatorsForm();
        //nie mozna traktowac formsow jako skladowe, bo przy zamknieciu i ponownym otwarciu pojawilby sie blad, poniewaz zamknelismy pole instacji

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tmp = MessageBox.Show("Do you want to close program?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tmp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel_date.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
            toolStripStatusLabel_server_name.Text = "Server address: " +SQLConnection.serverAddress;
            toolStripStatusLabel_user_name.Text = "User name: " + SQLConnection.user_login;

        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unitsForm uF = new unitsForm();
            uF.TopLevel = false;
            uF.AutoScroll = true;
            panel_main.Controls.Add(uF);
            uF.Show();
        }

        private void operatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorsForm oF = new OperatorsForm();
            oF.TopLevel = false;
            oF.AutoScroll = true;
            panel_main.Controls.Add(oF);
            oF.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productsForm pF = new productsForm();
            pF.TopLevel = false;
            pF.AutoScroll = true;
            panel_main.Controls.Add(pF);
            pF.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsForm cF = new clientsForm();
            cF.TopLevel = false;
            cF.AutoScroll = true;
            panel_main.Controls.Add(cF);
            cF.Show();
        }

        private void toolStripStatusLabel_date_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel_user_name_Click(object sender, EventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentForm doc = new documentForm();
            doc.TopLevel = false;
            doc.AutoScroll = true;
            panel_main.Controls.Add(doc);
            doc.Show();
        }

        private void toolStripStatusLabel_server_name_Click(object sender, EventArgs e)
        {

        }
    }
}
