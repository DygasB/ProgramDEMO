namespace ProgramDEMO
{
    partial class documentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_typ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ilosc = new System.Windows.Forms.TextBox();
            this.txt_wartosc = new System.Windows.Forms.TextBox();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.txt_produkt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_wartoscPozycji = new System.Windows.Forms.TextBox();
            this.txt_sumaPozycji = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.txt_sygnatura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nip = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_bottom.Controls.Add(this.menuStrip1);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 767);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1345, 64);
            this.panel_bottom.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.addProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(237, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generateToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addProductToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.addProductToolStripMenuItem.Text = "Add product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // comboBox_typ
            // 
            this.comboBox_typ.FormattingEnabled = true;
            this.comboBox_typ.Location = new System.Drawing.Point(120, 34);
            this.comboBox_typ.Name = "comboBox_typ";
            this.comboBox_typ.Size = new System.Drawing.Size(230, 27);
            this.comboBox_typ.TabIndex = 2;
            this.comboBox_typ.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox_typ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_typ_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dokument:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txt_ilosc);
            this.groupBox2.Controls.Add(this.txt_wartosc);
            this.groupBox2.Controls.Add(this.txt_cena);
            this.groupBox2.Controls.Add(this.txt_produkt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1253, 516);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pozycje dokumentu - produkty";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_ilosc
            // 
            this.txt_ilosc.Location = new System.Drawing.Point(762, 48);
            this.txt_ilosc.MaxLength = 3;
            this.txt_ilosc.Name = "txt_ilosc";
            this.txt_ilosc.Size = new System.Drawing.Size(230, 26);
            this.txt_ilosc.TabIndex = 6;
            this.txt_ilosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ilosc_KeyPress);
            // 
            // txt_wartosc
            // 
            this.txt_wartosc.Location = new System.Drawing.Point(108, 119);
            this.txt_wartosc.Name = "txt_wartosc";
            this.txt_wartosc.Size = new System.Drawing.Size(230, 26);
            this.txt_wartosc.TabIndex = 6;
            // 
            // txt_cena
            // 
            this.txt_cena.Location = new System.Drawing.Point(435, 48);
            this.txt_cena.MaxLength = 6;
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(230, 26);
            this.txt_cena.TabIndex = 6;
            this.txt_cena.TextChanged += new System.EventHandler(this.txt_cena_TextChanged);
            this.txt_cena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cena_KeyPress);
            // 
            // txt_produkt
            // 
            this.txt_produkt.Location = new System.Drawing.Point(108, 48);
            this.txt_produkt.Name = "txt_produkt";
            this.txt_produkt.Size = new System.Drawing.Size(230, 26);
            this.txt_produkt.TabIndex = 6;
            this.txt_produkt.TextChanged += new System.EventHandler(this.txt_produkt_TextChanged);
            this.txt_produkt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_produkt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ilość:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Wartość:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produkt:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 185);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1172, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tick";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sygnatura";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Produkt";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ilość";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Wartość";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Typ";
            this.columnHeader9.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txt_clientID);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_wartoscPozycji);
            this.groupBox1.Controls.Add(this.txt_sumaPozycji);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox_Client);
            this.groupBox1.Controls.Add(this.txt_sygnatura);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_nip);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1253, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nagłówek";
            // 
            // txt_clientID
            // 
            this.txt_clientID.Location = new System.Drawing.Point(798, 96);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.Size = new System.Drawing.Size(230, 26);
            this.txt_clientID.TabIndex = 10;
            this.txt_clientID.TextChanged += new System.EventHandler(this.txt_signature_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(671, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_wartoscPozycji
            // 
            this.txt_wartoscPozycji.Location = new System.Drawing.Point(460, 96);
            this.txt_wartoscPozycji.Name = "txt_wartoscPozycji";
            this.txt_wartoscPozycji.Size = new System.Drawing.Size(230, 26);
            this.txt_wartoscPozycji.TabIndex = 6;
            // 
            // txt_sumaPozycji
            // 
            this.txt_sumaPozycji.Location = new System.Drawing.Point(108, 96);
            this.txt_sumaPozycji.Name = "txt_sumaPozycji";
            this.txt_sumaPozycji.Size = new System.Drawing.Size(230, 26);
            this.txt_sumaPozycji.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Konrahent ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Wartość pozycji:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kontrahent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Suma pozycji:";
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(108, 43);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(230, 27);
            this.comboBox_Client.TabIndex = 4;
            this.comboBox_Client.SelectedIndexChanged += new System.EventHandler(this.comboBox_Client_SelectedIndexChanged);
            this.comboBox_Client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Client_KeyPress);
            // 
            // txt_sygnatura
            // 
            this.txt_sygnatura.Location = new System.Drawing.Point(1005, 43);
            this.txt_sygnatura.Name = "txt_sygnatura";
            this.txt_sygnatura.Size = new System.Drawing.Size(230, 26);
            this.txt_sygnatura.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "NIP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(927, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Sygnatura:";
            // 
            // txt_nip
            // 
            this.txt_nip.Location = new System.Drawing.Point(388, 43);
            this.txt_nip.MaxLength = 10;
            this.txt_nip.Name = "txt_nip";
            this.txt_nip.Size = new System.Drawing.Size(230, 26);
            this.txt_nip.TabIndex = 6;
            this.txt_nip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nip_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(624, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Data:";
            // 
            // documentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1345, 831);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_typ);
            this.Controls.Add(this.panel_bottom);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "documentForm";
            this.Text = "documentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.documentForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_bottom;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem generateToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ComboBox comboBox_typ;
        private Label label1;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private GroupBox groupBox1;
        private TextBox txt_produkt;
        private TextBox txt_wartoscPozycji;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox_Client;
        private TextBox txt_sygnatura;
        private Label label11;
        private Label label12;
        private TextBox txt_nip;
        private Label label13;
        private TextBox txt_cena;
        private TextBox txt_sumaPozycji;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_ilosc;
        private TextBox txt_wartosc;
        private Label label5;
        private ColumnHeader columnHeader10;
        private TextBox txt_clientID;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}