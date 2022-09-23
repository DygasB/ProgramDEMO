using System;
using System.IO;
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
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //utworzenie folderu aplikacyjnego
            Directory.CreateDirectory(SQLConnection.pathFolder);
            using(FileStream fS = File.Create(SQLConnection.pathFile))
            {
                //tworzenie struktury pliku
                Byte[] configurationParameters = new UTF8Encoding(true).GetBytes(txt_servername.Text + ";" + txt_username.Text + ";" + txt_password.Text );
                //zapis struktury do pliku
                fS.Write(configurationParameters,0, configurationParameters.Length);
            }
            SQLConnection.checkParameters();
        }
    }
}
