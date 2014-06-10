namespace Client
{
    partial class GuestPanel
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
            this.questMenu = new System.Windows.Forms.ToolStrip();
            this.lbluserName = new System.Windows.Forms.ToolStripLabel();
            this.login_userName = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripLabel();
            this.exit_home = new System.Windows.Forms.ToolStripSeparator();
            this.btnHome = new System.Windows.Forms.ToolStripLabel();
            this.btnLogin = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // questMenu
            // 
            this.questMenu.BackColor = System.Drawing.SystemColors.WindowText;
            this.questMenu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.questMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.questMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbluserName,
            this.login_userName,
            this.btnExit,
            this.exit_home,
            this.btnHome,
            this.btnLogin});
            this.questMenu.Location = new System.Drawing.Point(0, 0);
            this.questMenu.Name = "questMenu";
            this.questMenu.Size = new System.Drawing.Size(984, 31);
            this.questMenu.TabIndex = 2;
            this.questMenu.Text = "toolStrip1";
            this.questMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.questMenu_ItemClicked);
            // 
            // lbluserName
            // 
            this.lbluserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbluserName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(63, 28);
            this.lbluserName.Text = "Quest";
            // 
            // login_userName
            // 
            this.login_userName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.login_userName.Name = "login_userName";
            this.login_userName.Size = new System.Drawing.Size(6, 31);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 28);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // exit_home
            // 
            this.exit_home.Name = "exit_home";
            this.exit_home.Size = new System.Drawing.Size(6, 31);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(65, 28);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(61, 28);
            this.btnLogin.Text = "LogIn";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 461);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GuestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.questMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestPanel";
            this.Text = "GuestPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GuestPanel_Load);
            this.questMenu.ResumeLayout(false);
            this.questMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip questMenu;
        private System.Windows.Forms.ToolStripLabel lbluserName;
        private System.Windows.Forms.ToolStripSeparator login_userName;
        private System.Windows.Forms.ToolStripLabel btnExit;
        private System.Windows.Forms.ToolStripSeparator exit_home;
        private System.Windows.Forms.ToolStripLabel btnHome;
        private System.Windows.Forms.ToolStripLabel btnLogin;
        private System.Windows.Forms.Panel panel1;
    }
}