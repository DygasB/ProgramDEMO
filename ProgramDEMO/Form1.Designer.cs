namespace ProgramDEMO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_log_in = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.l_login = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check_show = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(256, 29);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 35);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(357, 29);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 35);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_check.Location = new System.Drawing.Point(458, 29);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(95, 35);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "Settings";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_log_in
            // 
            this.btn_log_in.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_log_in.Location = new System.Drawing.Point(559, 29);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(95, 35);
            this.btn_log_in.TabIndex = 3;
            this.btn_log_in.Text = "Log in";
            this.btn_log_in.UseVisualStyleBackColor = true;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_login.Location = new System.Drawing.Point(357, 248);
            this.txt_login.MaxLength = 20;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(297, 26);
            this.txt_login.TabIndex = 4;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(354, 306);
            this.txt_password.MaxLength = 20;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(300, 26);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "Password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_login.Location = new System.Drawing.Point(256, 251);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(46, 19);
            this.l_login.TabIndex = 6;
            this.l_login.Text = "Login:";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_password.Location = new System.Drawing.Point(256, 309);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(72, 19);
            this.l_password.TabIndex = 7;
            this.l_password.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.btn_log_in);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 152);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(559, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 10);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // check_show
            // 
            this.check_show.AutoSize = true;
            this.check_show.Location = new System.Drawing.Point(599, 338);
            this.check_show.Name = "check_show";
            this.check_show.Size = new System.Drawing.Size(55, 19);
            this.check_show.TabIndex = 9;
            this.check_show.Text = "Show";
            this.check_show.UseVisualStyleBackColor = true;
            this.check_show.CheckedChanged += new System.EventHandler(this.check_show_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(972, 515);
            this.Controls.Add(this.check_show);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_exit;
        private Button btn_clear;
        private Button btn_check;
        private Button btn_log_in;
        private TextBox txt_login;
        private TextBox txt_password;
        private Label l_login;
        private Label l_password;
        private Panel panel1;
        private CheckBox check_show;
        private Panel panel2;
    }
}