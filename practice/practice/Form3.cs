using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();

            }
            
        }
        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen != null)
            {
                activescreen.Close();
            }
            Form1 f = new Form1();
            f.MdiParent= this;
            f.Show();
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if(activescreen != null)
            {
                activescreen.Close();
            }
            search s = new search();
            s.MdiParent = this;
            s.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
