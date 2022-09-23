namespace ProgramDEMO
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.statusStrip_bottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_server_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_user_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.menuStrip_exit = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_top = new System.Windows.Forms.MenuStrip();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_bottom.SuspendLayout();
            this.statusStrip_bottom.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.menuStrip_exit.SuspendLayout();
            this.menuStrip_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.Info;
            this.panel_bottom.Controls.Add(this.statusStrip_bottom);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_bottom.Location = new System.Drawing.Point(0, 652);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1329, 80);
            this.panel_bottom.TabIndex = 0;
            // 
            // statusStrip_bottom
            // 
            this.statusStrip_bottom.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip_bottom.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip_bottom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_server_name,
            this.toolStripStatusLabel_user_name,
            this.toolStripStatusLabel_date});
            this.statusStrip_bottom.Location = new System.Drawing.Point(12, 41);
            this.statusStrip_bottom.Name = "statusStrip_bottom";
            this.statusStrip_bottom.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip_bottom.Size = new System.Drawing.Size(258, 24);
            this.statusStrip_bottom.SizingGrip = false;
            this.statusStrip_bottom.TabIndex = 0;
            this.statusStrip_bottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_server_name
            // 
            this.toolStripStatusLabel_server_name.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabel_server_name.Name = "toolStripStatusLabel_server_name";
            this.toolStripStatusLabel_server_name.Size = new System.Drawing.Size(88, 19);
            this.toolStripStatusLabel_server_name.Text = "Server name:";
            this.toolStripStatusLabel_server_name.Click += new System.EventHandler(this.toolStripStatusLabel_server_name_Click);
            // 
            // toolStripStatusLabel_user_name
            // 
            this.toolStripStatusLabel_user_name.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabel_user_name.Name = "toolStripStatusLabel_user_name";
            this.toolStripStatusLabel_user_name.Size = new System.Drawing.Size(77, 19);
            this.toolStripStatusLabel_user_name.Text = "User name:";
            this.toolStripStatusLabel_user_name.Click += new System.EventHandler(this.toolStripStatusLabel_user_name_Click);
            // 
            // toolStripStatusLabel_date
            // 
            this.toolStripStatusLabel_date.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabel_date.Name = "toolStripStatusLabel_date";
            this.toolStripStatusLabel_date.Size = new System.Drawing.Size(41, 19);
            this.toolStripStatusLabel_date.Text = "Date:";
            this.toolStripStatusLabel_date.Click += new System.EventHandler(this.toolStripStatusLabel_date_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.Info;
            this.panel_top.Controls.Add(this.menuStrip_exit);
            this.panel_top.Controls.Add(this.menuStrip_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1329, 127);
            this.panel_top.TabIndex = 1;
            // 
            // menuStrip_exit
            // 
            this.menuStrip_exit.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip_exit.Location = new System.Drawing.Point(1097, 11);
            this.menuStrip_exit.Name = "menuStrip_exit";
            this.menuStrip_exit.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip_exit.Size = new System.Drawing.Size(54, 45);
            this.menuStrip_exit.TabIndex = 3;
            this.menuStrip_exit.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 39);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip_top
            // 
            this.menuStrip_top.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip_top.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_top.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.extensionsToolStripMenuItem});
            this.menuStrip_top.Location = new System.Drawing.Point(12, 11);
            this.menuStrip_top.Name = "menuStrip_top";
            this.menuStrip_top.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip_top.Size = new System.Drawing.Size(233, 45);
            this.menuStrip_top.TabIndex = 2;
            this.menuStrip_top.Text = "menuStrip1";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.documentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("documentsToolStripMenuItem.Image")));
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(89, 39);
            this.documentsToolStripMenuItem.Text = "Documents";
            this.documentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.generateReportToolStripMenuItem.Text = "Generate report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.operatorsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.unitsToolStripMenuItem});
            this.filesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filesToolStripMenuItem.Image")));
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(49, 39);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // operatorsToolStripMenuItem
            // 
            this.operatorsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.operatorsToolStripMenuItem.Name = "operatorsToolStripMenuItem";
            this.operatorsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.operatorsToolStripMenuItem.Text = "Operators";
            this.operatorsToolStripMenuItem.Click += new System.EventHandler(this.operatorsToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.unitsToolStripMenuItem.Text = "Units";
            this.unitsToolStripMenuItem.Click += new System.EventHandler(this.unitsToolStripMenuItem_Click);
            // 
            // extensionsToolStripMenuItem
            // 
            this.extensionsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.extensionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("extensionsToolStripMenuItem.Image")));
            this.extensionsToolStripMenuItem.Name = "extensionsToolStripMenuItem";
            this.extensionsToolStripMenuItem.Size = new System.Drawing.Size(85, 39);
            this.extensionsToolStripMenuItem.Text = "Extensions";
            this.extensionsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_main.Location = new System.Drawing.Point(0, 127);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1329, 525);
            this.panel_main.TabIndex = 2;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 732);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_bottom);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip_top;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.statusStrip_bottom.ResumeLayout(false);
            this.statusStrip_bottom.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.menuStrip_exit.ResumeLayout(false);
            this.menuStrip_exit.PerformLayout();
            this.menuStrip_top.ResumeLayout(false);
            this.menuStrip_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_bottom;
        private Panel panel_top;
        private MenuStrip menuStrip_exit;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip_top;
        private ToolStripMenuItem documentsToolStripMenuItem;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem extensionsToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem operatorsToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem unitsToolStripMenuItem;
        private StatusStrip statusStrip_bottom;
        private ToolStripStatusLabel toolStripStatusLabel_server_name;
        private ToolStripStatusLabel toolStripStatusLabel_user_name;
        private ToolStripStatusLabel toolStripStatusLabel_date;
        private Panel panel_main;
        private ToolStripMenuItem generateReportToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}