namespace Client
{
    partial class SubForumPanel
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_fNamel = new System.Windows.Forms.Label();
            this.tblSubForums = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sdnSubForums = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_fNamel
            // 
            this.lb_fNamel.AutoSize = true;
            this.lb_fNamel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_fNamel.Location = new System.Drawing.Point(27, 14);
            this.lb_fNamel.Name = "lb_fNamel";
            this.lb_fNamel.Size = new System.Drawing.Size(0, 46);
            this.lb_fNamel.TabIndex = 0;
            // 
            // tblSubForums
            // 
            this.tblSubForums.ColumnCount = 2;
            this.tblSubForums.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSubForums.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSubForums.Location = new System.Drawing.Point(62, 23);
            this.tblSubForums.Name = "tblSubForums";
            this.tblSubForums.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSubForums.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSubForums.Size = new System.Drawing.Size(700, 0);
            this.tblSubForums.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.sdnSubForums);
            this.panel1.Controls.Add(this.tblSubForums);
            this.panel1.Location = new System.Drawing.Point(57, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 333);
            this.panel1.TabIndex = 2;
            // 
            // sdnSubForums
            // 
            this.sdnSubForums.LargeChange = 1;
            this.sdnSubForums.Location = new System.Drawing.Point(811, 0);
            this.sdnSubForums.Maximum = 0;
            this.sdnSubForums.Name = "sdnSubForums";
            this.sdnSubForums.Size = new System.Drawing.Size(24, 321);
            this.sdnSubForums.TabIndex = 2;
            this.sdnSubForums.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sdnSubForums_Scroll);
            // 
            // SubForumPanel
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_fNamel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 400);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "SubForumPanel";
            this.Load += new System.EventHandler(this.SubForumPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fNamel;
        private System.Windows.Forms.TableLayoutPanel tblSubForums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar sdnSubForums;


    }
}
