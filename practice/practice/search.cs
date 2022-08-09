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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void searchb_Click(object sender, EventArgs e)
        {
            var pro = model.findOne(searchb.Text);
            if(pro != null)
            {
                MessageBox.Show("not found");
            }
            else
            {
                model.findOne(pro.objectname);
                MessageBox.Show("not found");

            }
        }
    }
}
