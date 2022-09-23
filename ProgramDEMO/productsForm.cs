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
//using Library.ProgramDEMO.SQLConnection;
using System.Data.SqlClient;
namespace ProgramDEMO
{
    public partial class productsForm : Form
    {
        private Products p = new Products();
        private string recordId;
        public productsForm()
        {
            InitializeComponent();
            p.loadDataFromDb(this.listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertProduct iP = new insertProduct();
            iP.TopLevel = false;
            iP.AutoScroll = true;
            listView1.Controls.Add(iP);
            iP.Show();
            refreshList();
        }
        private void refreshList()
        {
            this.listView1.Items.Clear();
            p.loadDataFromDb(this.listView1);
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
                p.deleteProduct(recordId = listView1.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                MessageBox.Show("Table is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshList();
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                recordId = listView1.SelectedItems[0].SubItems[1].Text;
                updateProduct uP = new updateProduct();
                uP.recordId = this.recordId;
                uP.TopLevel = false;
                uP.AutoScroll = true;
                this.listView1.Controls.Add(uP);
                uP.Show();
                refreshList();
            }
            else
            {
                MessageBox.Show("Select a record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void productsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
