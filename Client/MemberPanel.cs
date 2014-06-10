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
        private string _userName = "David";
        private string _forumName = "Cars";

        public MemberPanel(string forumName, string userName)
        {
            InitializeComponent();
            this.memberMenu.Items.Find("btnProfile", true)[0].Click += btnProfile_Clicked;
            this.memberMenu.Items.Find("btnHome", true)[0].Click += btnHome_Clicked;
            this._userName = userName;
            this._forumName = forumName;
            this.lbluserName.Text = this._userName;
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


        private void btnHome_Clicked(object sender, EventArgs e)
        {
            DefualtLayout();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _panel = new SubForumPanel(_forumName, new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "18", "19", "20", "18", "19", "20" }, btnSubForum_Clicked , this.Height , this.Width);
            _panel.TopLevel = false;
            _panel.Show();
            _panel.StartPosition = FormStartPosition.Manual;
            _panel.Location = new Point(this.Location.X + (this.Width - _panel.Width) / 2, this.Location.Y + (this.Height - _panel.Height) / 2);
            this.panel1.Controls.Add(_panel);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfilePanel profilePnael = new ProfilePanel(this.Height, this.Width);
            profilePnael.btnCancel.Click += btnClose_Clicked;
            profilePnael.btnOk.Click += btnOk_Clicked;
            profilePnael.TopLevel = false;
            profilePnael.StartPosition = FormStartPosition.Manual;
            profilePnael.Location = new Point(this.Location.X + (this.Width - profilePnael.Width) / 2, this.Location.Y + (this.Height - profilePnael.Height) / 2);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(profilePnael);
            profilePnael.Show(); 
        }

        private void btnSubForum_Clicked(object sender, EventArgs e)
        {
            PostPanel postPanel = new PostPanel(this._forumName, ((Button)sender).Text , this.Height , this.Width);
            postPanel.StartPosition = FormStartPosition.Manual;
            postPanel.Location = new Point(this.Location.X + (this.Width - postPanel.Width) / 2, this.Location.Y + (this.Height - postPanel.Height) / 2);
            postPanel.TopLevel = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(postPanel);

            ToolStripItem addPost = new ToolStripLabel();
            addPost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            addPost.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            addPost.Name = "btnAddPost";
            addPost.Size = new System.Drawing.Size(65, 28);
            addPost.Text = "Add Post";
            addPost.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            addPost.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            
            ToolStripItem Home_AddPost = new System.Windows.Forms.ToolStripSeparator();
            Home_AddPost.Name = "Home_AddPost";

            this.memberMenu.Items.Add(Home_AddPost);
            this.memberMenu.Items.Add(addPost);
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
                _userName = ((Button)sender).Text;
                this.lbluserName.Text = this._userName;
            }
            DefualtLayout();
        }

        private void DefualtLayout()
        {

            foreach (Control c in this.panel1.Controls)
                if (typeof(Form) == c.GetType())
                    ((Form)c).Close();

            this.panel1.Controls.Clear();

            this.memberMenu.Items.RemoveByKey("btnAddPost");
            this.memberMenu.Items.RemoveByKey("Home_AddPost");
            foreach (ToolStripItem btm in this.memberMenu.Items)
            {
                if (btm.Name != "lbluserName")
                {
                    btm.Enabled = true;
                    btm.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
                    btm.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
                }

            }
            lbluserName.Text = _userName;
            this.panel1.Controls.Add(this._panel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void memberMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbluserName_Click(object sender, EventArgs e)
        {

        }

        private void disconnect_userName_Click(object sender, EventArgs e)
        {

        }

        private void exit_home_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void Home_profile_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            GuestPanel gp = new GuestPanel(_forumName);
            gp.ShowDialog();
            this.Close();

        }



    }
}
