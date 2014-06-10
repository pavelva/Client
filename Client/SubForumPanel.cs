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
    public partial class SubForumPanel : Form
    {
        private List<String> sfNames;
        private string fName;
        private string sfName;
        private System.EventHandler SubForumBtnClickHandler;

        public SubForumPanel(string fName, List<String> sfNames, System.EventHandler SubForumBtnClickHandler, int h, int w)
        {
            InitializeComponent();
            this.sfNames = sfNames;
            this.fName = fName;
            this.SubForumBtnClickHandler = SubForumBtnClickHandler;

            //this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Size = new Size( w/2,h);
            this.StartPosition = FormStartPosition.CenterParent;

            panel1.Size = new Size( this.Width /2 ,this.Height/2 + 150 );
            panel1.MaximumSize = panel1.Size;
            lb_fNamel.Text = "Welcome To Forum " + fName;

            this.tblSubForums.RowStyles.Clear();
            this.tblSubForums.Size = new System.Drawing.Size(panel1.Width - 90, (sfNames.Count / 2) * 90  + 50);

            tblSubForums.Controls.Clear();
            for (int i = 0; i < sfNames.Count; i++)
            {
                    tblSubForums.Controls.Add(subForumButtonCreator(sfNames[ i]), i % 2, i / 2);
            }
        }
        private void SubForumPanel_Load(object sender, EventArgs e)
        {
           
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public string getSubForumName()
        {
            return this.sfName;
        }
        private Button subForumButtonCreator(string name)
        {
            Button btn = new Button();
            btn.Size = new Size(300,85);
            btn.Text = name;
            btn.BackColor = Color.FromArgb(29, 159, 222);
            btn.Font = new Font("algerian", 20, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(241, 241, 241);
            btn.FlatAppearance.BorderSize = 1;
            btn.Click += SubForumBtnClickHandler;
            btn.MouseEnter += new System.EventHandler(btn_MouseEnter);
            btn.MouseLeave += new System.EventHandler(btn_MouseLeave);
            return btn;
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            MouseHandler.mouseEnterBtn(this);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            MouseHandler.mouseLeaveBtn(this);
        }



    }
}
