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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            MouseHandler.mouseEnterBtn(this); 
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            MouseHandler.mouseLeaveBtn(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubForumPanel s = new SubForumPanel ( "Cars", new List<string>(){"fiat", "bmw", "subaru", "ford", "susita"});
            s.TopLevel = false;
            s.Show();

            this.panel1.Controls.Add(s);
        }


    }
}
