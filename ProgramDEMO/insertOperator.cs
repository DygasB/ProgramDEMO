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

namespace ProgramDEMO
{
    public partial class insertOperator : Form
    {
        private Operators o = new Operators();
        public insertOperator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void insertOperator_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o.addNewOperator(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
