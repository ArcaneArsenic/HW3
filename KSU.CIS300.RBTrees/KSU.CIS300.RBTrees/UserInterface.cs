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
            StreamReader tempFile = new StreamReader(fn);
            //see Labs
            
        }

        private void uxLoadNames_Click(object sender, EventArgs e)
        {
            _tree = (RBTree<NameEntry>)sender;
            try { new TreeForm((ITree)_tree, 10000).Show(); }
            catch (Exception) { MessageBox.Show("Error"); }

        }

        private void uxLookUp_Click(object sender, EventArgs e)
        {
            //call Find
            NameEntry rez = new NameEntry();
            NameEntry temp = new NameEntry();
            if (_tree.Find(temp,out rez))
            {
                uxFreqOut.Text = temp.Frequency.ToString();
                uxRankOut.Text = temp.Rank.ToString();
            }
            else 
            {
                MessageBox.Show("nah");
                uxFreqOut.Text = "";
                uxRankOut.Text = "";

            }
           
        }

        private void uxRemoveName_Click(object sender, EventArgs e, NameEntry temp)
        {
            //if(temp = null)
            //find rel. Lab i guess
        }
    }
}
