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
        private int table_index = 0;
        public SubForumPanel(string fName, List<String> sfNames)
        {
            InitializeComponent();
            this.sfNames = sfNames;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            sdnSubForums.Width = 25;
            sdnSubForums.Height = this.panel1.Height;
            sdnSubForums.Minimum = 0;
            sdnSubForums.Maximum = ( sfNames.Count / 6);
            sdnSubForums.Value = 0;
            sdnSubForums.LargeChange = 1;
            sdnSubForums.SmallChange = 1;
            sdnSubForums.MouseEnter += new System.EventHandler(btn_MouseEnter);
            sdnSubForums.MouseLeave += new System.EventHandler(btn_MouseLeave);


            lb_fNamel.Text = "Welcome To Forum " + fName;

            int width = tblSubForums.Width;
            int height = tblSubForums.Height;
            tblSubForums.RowStyles.Clear();
            this.tblSubForums.Size = new System.Drawing.Size(width, height + (6) * 90);

            painTable(0, sfNames);
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


        private void sdnSubForums_Scroll(object sender, ScrollEventArgs e)
        {
                painTable(sdnSubForums.Value*6, sfNames);
                table_index = sdnSubForums.Value;
        }

        public void painTable(int index , List<String> sfNames)
        {
            tblSubForums.Controls.Clear();
            for (int i = 0; i < 6; i++)
            {
                if (index  + i < sfNames.Count)
                    tblSubForums.Controls.Add(subForumButtonCreator(sfNames[index + i]), i % 2, i / 2);
            }
        }

    }
}
