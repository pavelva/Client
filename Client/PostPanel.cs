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
    public partial class PostPanel : Form
    {
        private Dictionary <int, List<string>> posts;
        private Dictionary<int, int> postsParents;
        private string _forumName;
        private string _subForumName;
        public PostPanel(string forumName, string subForumName)
        {
            InitializeComponent();
            posts = new Dictionary<int, List<string>>();
            postsParents = new Dictionary<int, int>();
            this._forumName = forumName;
            this._subForumName = subForumName;
        }

        private void PostPanel_Load(object sender, EventArgs e)
        {
            lb_subForum.Text = "Welcome To Sub Forum " + _subForumName;
        }
    }
}
