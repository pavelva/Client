using Client.menuUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MemberPanel : Form
    {
        private Form _panel;
        private string userName = "David";
        public MemberPanel()
        {
            InitializeComponent();
            this.memberMenu.Items.Find("btnProfile", true)[0].Click += btnProfile_Clicked;
            this.memberMenu.Items.Find("btnDisconnect", true)[0].Click += btnDisconnect_Clicked;
            this.lbluserName.Text = userName;
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            MouseHandler.mouseEnterBtn(this); 
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            MouseHandler.mouseLeaveBtn(this);
        }

        private void btnProfile_Clicked(object sender, EventArgs e)
        {
            ToolStripItem btnProfile = this.memberMenu.Items.Find("btnProfile", true)[0];
            btnProfile.Enabled = false;
            btnProfile.MouseEnter -= btn_MouseEnter;
            btnProfile.MouseLeave -= btn_MouseLeave;
            this.Cursor = Cursors.Default;
            this.panel1.Controls.Remove(this._panel);
        }

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove((Control)sender);
            foreach(ToolStripItem btm in this.memberMenu.Items){
                if (btm.Name != "lbluserName")
                {
                    btm.Enabled = true;
                    btm.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
                    btm.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
                }
            }
            this.panel1.Controls.Add(this._panel);
        }

        private void btnDisconnect_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Disconnect");
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            _panel = new SubForumPanel("Cars", new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "18", "19", "20", "18", "19", "20" });
            _panel.TopLevel = false;
            _panel.Show();
            this.panel1.Controls.Add(_panel);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfilePanel profilePnael = new ProfilePanel();
            profilePnael.
        }

    }
}
