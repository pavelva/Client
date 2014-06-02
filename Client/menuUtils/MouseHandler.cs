using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.menuUtils
{
    public static class MouseHandler
    {
        public static void mouseEnterBtn(Form f)
        {
            f.Cursor = Cursors.Hand;
        }

        public static void mouseLeaveBtn(Form f)
        {
            f.Cursor = Cursors.Default;
        }
    }
}
