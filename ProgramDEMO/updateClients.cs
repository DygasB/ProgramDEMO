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
    public partial class updateClients : Form
    {
        public string recordId;
        Clients c = new Clients();
        public updateClients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox2.Focus();
        }

        private void updateClients_Load(object sender, EventArgs e)
        {
            textBox1.Text = recordId;
            textBox1.Enabled = false;
            c.loadDataFromDbToUpdateForm(recordId, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.editClient(this.recordId, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
