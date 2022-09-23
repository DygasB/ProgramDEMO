using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramDEMO.Class;
using System.Data.SqlClient;
//using Library.ProgramDEMO.SQLConnection;


namespace ProgramDEMO
{
    public partial class clientsForm : Form
    {
        private Clients c = new Clients();
        private string recordId;
        public clientsForm()
        {
            InitializeComponent();
            c.loadDataFromDb(this.listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void refreshList()
        {
            listView1.Items.Clear();
            c.loadDataFromDb(this.listView1);
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The number of records in the database = {listView1.Items.Count}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                c.deleteClient(listView1.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                MessageBox.Show("Table is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshList();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertClient iC = new insertClient();
            iC.TopLevel = false;
            iC.AutoScroll = true;
            this.listView1.Controls.Add(iC);
            iC.Show();
            refreshList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                this.recordId = listView1.SelectedItems[0].SubItems[1].Text;
                updateClients uC = new updateClients();
                uC.recordId = this.recordId;
                uC.TopLevel = false;
                uC.AutoScroll = true;
                listView1.Controls.Add(uC);
                uC.Show();
            }
            else
            {
                MessageBox.Show("Select a record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshList();
        }

        private void clientsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
