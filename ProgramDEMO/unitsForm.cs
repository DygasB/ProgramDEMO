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
    public partial class unitsForm : Form
    {
        private Units u = new Units();
        private string recordId;
        public unitsForm()
        {
            InitializeComponent();
        }
      
        private void unitsForm_Load(object sender, EventArgs e)
        {
            u.loadDataFromDb(this.listView1);
            //this.WindowState = FormWindowState.Maximized;
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertUnit iU = new insertUnit();
            //iU.Show();
            iU.TopLevel = false;
            iU.AutoScroll = true;
            this.listView1.Controls.Add(iU);
            iU.Show();
            refreshList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                recordId = listView1.SelectedItems[0].SubItems[1].Text;
                updateForm uF = new updateForm();
                uF.recordId = this.recordId;
                //uF.Show();
                uF.TopLevel = false;
                uF.AutoScroll = true;
                this.listView1.Controls.Add(uF);
                uF.Show();
                refreshList();
            }
            else
            {
                MessageBox.Show("Select a record", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                u.deleteUnit(listView1.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                MessageBox.Show("Table is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshList();
        }
        private void refreshList()
        {
            this.listView1.Items.Clear();
            u.loadDataFromDb(this.listView1);
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The number of records in the database = {listView1.Items.Count}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
