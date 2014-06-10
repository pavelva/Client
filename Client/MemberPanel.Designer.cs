namespace Client
{
    partial class MemberPanel
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
            this.memberMenu = new System.Windows.Forms.ToolStrip();
            this.lbluserName = new System.Windows.Forms.ToolStripLabel();
            this.disconnect_userName = new System.Windows.Forms.ToolStripSeparator();
            this.btnHome = new System.Windows.Forms.ToolStripLabel();
            this.Home_profile = new System.Windows.Forms.ToolStripSeparator();
            this.btnProfile = new System.Windows.Forms.ToolStripLabel();
            this.btnDisconnect = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberMenu
            // 
            this.memberMenu.BackColor = System.Drawing.SystemColors.WindowText;
            this.memberMenu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.memberMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.memberMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbluserName,
            this.disconnect_userName,
            this.btnHome,
            this.Home_profile,
            this.btnProfile,
            this.btnDisconnect});
            this.memberMenu.Location = new System.Drawing.Point(0, 0);
            this.memberMenu.Name = "memberMenu";
            this.memberMenu.Size = new System.Drawing.Size(1000, 31);
            this.memberMenu.TabIndex = 0;
            this.memberMenu.Text = "toolStrip1";
            this.memberMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.memberMenu_ItemClicked);
            // 
            // lbluserName
            // 
            this.lbluserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbluserName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(100, 28);
            this.lbluserName.Text = "userName";
            // 
            // disconnect_userName
            // 
            this.disconnect_userName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.disconnect_userName.Name = "disconnect_userName";
            this.disconnect_userName.Size = new System.Drawing.Size(6, 31);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(65, 28);
            this.btnHome.Text = "Home";
            this.btnHome.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // Home_profile
            // 
            this.Home_profile.Name = "Home_profile";
            this.Home_profile.Size = new System.Drawing.Size(6, 31);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(68, 28);
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(108, 28);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnDisconnect.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 469);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MemberPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.memberMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MemberPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forum Genarator System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.memberMenu.ResumeLayout(false);
            this.memberMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip memberMenu;
        private System.Windows.Forms.ToolStripLabel lbluserName;
        private System.Windows.Forms.ToolStripSeparator disconnect_userName;
        private System.Windows.Forms.ToolStripLabel btnProfile;
        private System.Windows.Forms.ToolStripLabel btnDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel btnHome;
        private System.Windows.Forms.ToolStripSeparator Home_profile;

    }
}

