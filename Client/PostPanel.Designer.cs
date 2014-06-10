namespace Client
{
    partial class PostPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sdnSubForums = new System.Windows.Forms.VScrollBar();
            this.tblSubForums = new System.Windows.Forms.TableLayoutPanel();
            this.lb_subForum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.sdnSubForums);
            this.panel1.Controls.Add(this.tblSubForums);
            this.panel1.Location = new System.Drawing.Point(55, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 333);
            this.panel1.TabIndex = 4;
            // 
            // sdnSubForums
            // 
            this.sdnSubForums.LargeChange = 1;
            this.sdnSubForums.Location = new System.Drawing.Point(811, 0);
            this.sdnSubForums.Maximum = 0;
            this.sdnSubForums.Name = "sdnSubForums";
            this.sdnSubForums.Size = new System.Drawing.Size(24, 321);
            this.sdnSubForums.TabIndex = 2;
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
            // lb_subForum
            // 
            this.lb_subForum.AutoSize = true;
            this.lb_subForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_subForum.Location = new System.Drawing.Point(12, 18);
            this.lb_subForum.Name = "lb_subForum";
            this.lb_subForum.Size = new System.Drawing.Size(0, 46);
            this.lb_subForum.TabIndex = 5;
            // 
            // PostPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Controls.Add(this.lb_subForum);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostPanel";
            this.Text = "PostPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PostPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar sdnSubForums;
        private System.Windows.Forms.TableLayoutPanel tblSubForums;
        private System.Windows.Forms.Label lb_subForum;
    }
}