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
    public partial class ProfilePanel : Form
    {
        public ProfilePanel(int h, int w)
        {
            InitializeComponent();
            this.Size = new Size(2*w/3, h);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void ProfilePanel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.tbEmail.Enabled = true;
            this.tbName.Enabled = true;
            this.tbPassword.Enabled = true;
            this.datePicker.Enabled = true;
            this.btnOk.Visible = true;
            this.btnEdit.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           btnOk.Text =  tbName.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
