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
    public partial class insertUnit : Form
    {
        private Units u = new Units();
        public insertUnit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.addNewUnit(textBox1.Text, textBox2.Text);
        }

        private void insertUnit_Load(object sender, EventArgs e)
        {

        }
    }
}
