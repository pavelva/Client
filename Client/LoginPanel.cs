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
    public partial class LoginPanel : Form
    {
        public LoginPanel(int h, int w)
        {
            InitializeComponent();
            this.Size = new Size(2 * w / 3, h);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.btnCancel.PerformClick();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            btnOk.Text = tbName.Text;
        }

    }
}
