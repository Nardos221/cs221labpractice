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
    public partial class UserControl1 : UserControl
    {

        private int _Title;

        public int Title
        {
            get { return _Title; }
            set { _Title= value; button1.Text = value.ToString(); }
        }
        private double _price;

        public double price
        {
            get { return _price; }
            set { _price = value; button2.Text = value.ToString(); }
        }
          public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
