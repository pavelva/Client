using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.menuUtils;
namespace Client
{
    public partial class GuestPanel : Form
    {
        private Form _panel;
        private string _forumName = "Cars";
        public GuestPanel(string forumName)
        {
            InitializeComponent();
            this._forumName = forumName;
        }

        private void GuestPanel_Load(object sender, EventArgs e)
        {
            _panel = new SubForumPanel(_forumName, new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "18", "19", "20", "18", "19", "20" }, btnSubForum_Clicked, this.Height, this.Width);
            _panel.TopLevel = false;
            _panel.Show();
            _panel.StartPosition = FormStartPosition.Manual;
            _panel.Location = new Point(this.Location.X + (this.Width - _panel.Width) / 2, this.Location.Y + (this.Height - _panel.Height) / 2);
            this.panel1.Controls.Add(_panel);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DefualtLayout();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DefualtLayout()
        {

            foreach (Control c in this.panel1.Controls)
                if (typeof(Form) == c.GetType())
                    ((Form)c).Close();

            this.panel1.Controls.Clear();

            this.questMenu.Items.RemoveByKey("btnAddPost");
            this.questMenu.Items.RemoveByKey("Home_AddPost");
            foreach (ToolStripItem btm in this.questMenu.Items)
            {
                if (btm.Name != "lbluserName")
                {
                    btm.Enabled = true;
                    btm.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
                    btm.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
                }

            }
            this.panel1.Controls.Add(this._panel);
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            MouseHandler.mouseEnterBtn(this);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            MouseHandler.mouseLeaveBtn(this);
        }

        private void btnSubForum_Clicked(object sender, EventArgs e)
        {
            PostPanel postPanel = new PostPanel(this._forumName, ((Button)sender).Text, this.Height, this.Width);
            postPanel.StartPosition = FormStartPosition.Manual;
            postPanel.Location = new Point(this.Location.X + (this.Width - postPanel.Width) / 2, this.Location.Y + (this.Height - postPanel.Height) / 2);
            postPanel.TopLevel = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(postPanel);
            postPanel.Show();
        }

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            DefualtLayout();
        }
        private void btnOk_Clicked(object sender, EventArgs e)
        {
            
            if (sender.GetType() == typeof(Button))
            {
                this.Hide();
                MemberPanel mp = new MemberPanel(_forumName, ((Button)sender).Text);
                mp.ShowDialog();
                this.Close();
            }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ToolStripItem btnLogin = this.questMenu.Items.Find("btnLogin", true)[0];
            btnLogin.Enabled = false;
            btnLogin.MouseEnter -= btn_MouseEnter;
            btnLogin.MouseLeave -= btn_MouseLeave;
            this.Cursor = Cursors.Default;
            this.panel1.Controls.Remove(this._panel);
            LoginPanel loginPanel = new LoginPanel(this.Height, this.Width);
            loginPanel.btnCancel.Click += btnClose_Clicked;
            loginPanel.btnOk.Click += btnOk_Clicked;
            loginPanel.TopLevel = false;
            loginPanel.StartPosition = FormStartPosition.Manual;
            loginPanel.Location = new Point(this.Location.X + (this.Width - loginPanel.Width) / 2, this.Location.Y + (this.Height - loginPanel.Height) / 2);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(loginPanel);
            loginPanel.Show(); 
        }

        private void questMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
