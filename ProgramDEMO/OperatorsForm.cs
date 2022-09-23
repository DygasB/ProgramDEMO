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
    public partial class OperatorsForm : Form
    {
        private Operators o = new Operators();
        private string recordId;
        public OperatorsForm()
        {
            InitializeComponent();
        }

        private void OperatorsForm_Load(object sender, EventArgs e)
        {
            o.loadDataFromDb(this.listView1);
        }
        private void refreshList()
        {
            listView1.Items.Clear();
            o.loadDataFromDb(this.listView1);
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
                o.deleteOperator(recordId = listView1.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                MessageBox.Show("Table is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                recordId = listView1.SelectedItems[0].SubItems[1].Text;
                updateOperator uO = new updateOperator();
                uO.recordId = this.recordId;
                uO.TopLevel = false;
                uO.AutoScroll = true;
                this.listView1.Controls.Add(uO);
                uO.Show();
                refreshList();
            }
            else
            {
                MessageBox.Show("Select a record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertOperator iO = new insertOperator();
            iO.TopLevel = false;
            iO.AutoScroll = true;
            listView1.Controls.Add(iO);
            iO.Show();
            refreshList();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                recordId = listView1.SelectedItems[0].SubItems[1].Text;
                
                DialogResult dr = MessageBox.Show("Should I log out of the selected user", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    o.loggedOutOperator(recordId);
                    MessageBox.Show("The operator is looged out succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshList();
                }
                else
                {
                    MessageBox.Show("The operator is still logged on", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                recordId = listView1.SelectedItems[0].SubItems[1].Text;

                DialogResult dr = MessageBox.Show("Should I log in of the selected user", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    o.loggedInOperator(recordId);
                    MessageBox.Show("The operator is looged in succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshList();
                }
                else
                {
                    MessageBox.Show("The operator is still logged on", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
