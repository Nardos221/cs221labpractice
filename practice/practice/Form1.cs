using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            model md = new model();
            md.number = txt_number.Text;
            md.date = dateTimePicker1.Text;
            md.inventorynum = txt_inventnum.Text;
            md.objectname = txt_objectname.Text;
            md.count = txt_count.Text;
            md.price = txt_price.Text;
            md.save();
            MessageBox.Show("item added");

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
