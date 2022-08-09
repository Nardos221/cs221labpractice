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
using System.Text.RegularExpressions;


namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Is Regular",CheckState.Checked);
            checkedListBox1.Items.Add("Is Unique",CheckState.Unchecked);
            checkedListBox1.Items.Add("Is Null",CheckState.Indeterminate);

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
            checkedListBox1.CheckedItems.Contains(md);
            string message = " ";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                message +=item.ToString();
            }

            Regex regex = new Regex("@^(a-z)(z)$");
            if(regex.IsMatch(txt_objectname.Text))
            {
                MessageBox.Show("try");
            }
            else
                if(string.IsNullOrEmpty(txt_objectname.Text))
            {
                MessageBox.Show("item added");
                errorProvider1.SetError(txt_objectname, "add object name");

            }
            md.save();
            MessageBox.Show("item added");
            newgridproduct.DataSource = null;
            newgridproduct.DataSource = md.getall();

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index =checkedListBox1.SelectedIndex;
            int count=checkedListBox1.Items.Count;
            for(int x =0; x < count; x++)
            {
                if(index !=x)
                {
                   // checkedListBox1.SetItemChecked(x, false);
                   checkedListBox1.SetItemCheckState(x,CheckState.Checked);
                }
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            string choice = " ";
            if(raddioButton1.Checked)
            {
                choice = raddioButton1.Text;
                
            }
            if(radiobutton2.Checked)
            {
                choice=radiobutton2.Text;
                
            }
            MessageBox.Show(choice);
                   }

        private void button1_Click(object sender, EventArgs e)
        {
            
            }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var pro = model.findOne(tbsearch.Text);
            if(pro== null)
            {
                MessageBox.Show("not found");
            }
            else
            {
                model.findOne(pro.objectname);
                MessageBox.Show("found");
            }
        }
    }
    }

