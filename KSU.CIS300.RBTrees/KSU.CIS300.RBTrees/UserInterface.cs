using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KansasStateUniversity.TreeViewer2;

namespace KSU.CIS300.RBTrees
{
    public partial class uxUserInterface : Form
    {
        public uxUserInterface()
        {
            //def. constructor
            InitializeComponent();
        }

        //the red black tree that is currently loaded
        private RBTree<NameEntry> _tree;
        public RBTree<T> curr;


        /// <summary>
        /// uses StreamReader
        /// Form: name, freq, rank, own line 
        /// </summary>
        /// <param name="fn"></param>
        /// <returns new tree></returns>
        private RBTree<NameEntry> ReadFile(string fn)
        { 
            
        }

        private void uxLoadNames_Click(object sender, EventArgs e)
        {

        }

        private void uxLookUp_Click(object sender, EventArgs e)
        {

        }

        private void uxRemoveName_Click(object sender, EventArgs e)
        {

        }
    }
}
