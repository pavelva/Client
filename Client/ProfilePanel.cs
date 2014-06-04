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
        public ProfilePanel()
        {
            InitializeComponent();
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
            //send data to server
            MessageBox.Show("1");
            this.btnCancel.PerformClick();
        }




    }
}
