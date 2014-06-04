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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripSeparator2,
            this.btnProfile,
            this.btnDisconnect});
            this.memberMenu.Location = new System.Drawing.Point(0, 0);
            this.memberMenu.Name = "memberMenu";
            this.memberMenu.Size = new System.Drawing.Size(984, 31);
            this.memberMenu.TabIndex = 0;
            this.memberMenu.Text = "toolStrip1";
            // 
            // lbluserName
            // 
            this.lbluserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbluserName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(100, 28);
            this.lbluserName.Text = "userName";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 431);
            this.panel1.TabIndex = 1;
            // 
            // MemberPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.memberMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MemberPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forum Genarator System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.memberMenu.ResumeLayout(false);
            this.memberMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip memberMenu;
        private System.Windows.Forms.ToolStripLabel lbluserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel btnProfile;
        private System.Windows.Forms.ToolStripLabel btnDisconnect;
        private System.Windows.Forms.Panel panel1;

    }
}

