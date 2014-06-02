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
        public SubForumPanel(string fName, List<String> sfNames)
        {
            InitializeComponent();

            lb_fNamel.Text = "Welcome To Forum " + fName;

            int width = tblSubForums.Width;
            int height = tblSubForums.Height;
            tblSubForums.RowStyles.Clear();
            this.tblSubForums.Size = new System.Drawing.Size(width, height + (sfNames.Count / 2 + sfNames.Count % 2) * 90);

            for (int i = 0; i < sfNames.Count; i++)
            {
                tblSubForums.Controls.Add(subForumButtonCreator(sfNames[i]), i % 2, i / 2); 
            }


        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
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
