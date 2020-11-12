using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refManager
{
    public partial class MyRef : Form
    {
        public MyRef()
        {
            InitializeComponent();
        }

        private void 냉장고추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefManager addref = new RefManager();
            addref.ShowDialog();
        }

        private void 품목추가ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddItem frm = new AddItem();
            frm.ShowDialog();
        }
    }
}
