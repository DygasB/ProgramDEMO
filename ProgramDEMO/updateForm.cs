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
    public partial class updateForm : Form
    {
        private Units u = new Units();
        public string recordId;
        public updateForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.editUnit(recordId, textBox1, textBox2);
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            textBox3.Text = recordId;
            textBox3.Enabled = false;
            u.loadDataFromDbToUpdateForm(recordId, textBox1, textBox2);
        }

        private void updateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
