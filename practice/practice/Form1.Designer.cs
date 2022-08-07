namespace practice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventorynum = new System.Windows.Forms.Label();
            this.objectname = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_objectname = new System.Windows.Forms.TextBox();
            this.txt_inventnum = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.newgridproduct = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.raddioButton1 = new System.Windows.Forms.RadioButton();
            this.radiobutton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.newgridproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(52, 24);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(42, 13);
            this.number.TabIndex = 0;
            this.number.Text = "number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "date";
            // 
            // inventorynum
            // 
            this.inventorynum.AutoSize = true;
            this.inventorynum.Location = new System.Drawing.Point(602, 24);
            this.inventorynum.Name = "inventorynum";
            this.inventorynum.Size = new System.Drawing.Size(88, 13);
            this.inventorynum.TabIndex = 2;
            this.inventorynum.Text = "inventory number";
            // 
            // objectname
            // 
            this.objectname.AutoSize = true;
            this.objectname.Location = new System.Drawing.Point(24, 117);
            this.objectname.Name = "objectname";
            this.objectname.Size = new System.Drawing.Size(65, 13);
            this.objectname.TabIndex = 3;
            this.objectname.Text = "object name";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(28, 183);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(34, 13);
            this.count.TabIndex = 4;
            this.count.Text = "count";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(198, 183);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(30, 13);
            this.price.TabIndex = 5;
            this.price.Text = "price";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(12, 256);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(201, 256);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(28, 64);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 20);
            this.txt_number.TabIndex = 8;
            // 
            // txt_objectname
            // 
            this.txt_objectname.Location = new System.Drawing.Point(31, 144);
            this.txt_objectname.Name = "txt_objectname";
            this.txt_objectname.Size = new System.Drawing.Size(455, 20);
            this.txt_objectname.TabIndex = 9;
            // 
            // txt_inventnum
            // 
            this.txt_inventnum.Location = new System.Drawing.Point(560, 64);
            this.txt_inventnum.Name = "txt_inventnum";
            this.txt_inventnum.Size = new System.Drawing.Size(155, 20);
            this.txt_inventnum.TabIndex = 10;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(12, 212);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 20);
            this.txt_count.TabIndex = 11;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(176, 212);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // newgridproduct
            // 
            this.newgridproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newgridproduct.Location = new System.Drawing.Point(12, 320);
            this.newgridproduct.Name = "newgridproduct";
            this.newgridproduct.Size = new System.Drawing.Size(457, 58);
            this.newgridproduct.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // raddioButton1
            // 
            this.raddioButton1.AutoSize = true;
            this.raddioButton1.Location = new System.Drawing.Point(32, 28);
            this.raddioButton1.Name = "raddioButton1";
            this.raddioButton1.Size = new System.Drawing.Size(60, 17);
            this.raddioButton1.TabIndex = 15;
            this.raddioButton1.TabStop = true;
            this.raddioButton1.Text = "Sample";
            this.raddioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobutton2
            // 
            this.radiobutton2.AutoSize = true;
            this.radiobutton2.Location = new System.Drawing.Point(32, 51);
            this.radiobutton2.Name = "radiobutton2";
            this.radiobutton2.Size = new System.Drawing.Size(62, 17);
            this.radiobutton2.TabIndex = 16;
            this.radiobutton2.TabStop = true;
            this.radiobutton2.Text = "variable";
            this.radiobutton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raddioButton1);
            this.groupBox1.Controls.Add(this.radiobutton2);
            this.groupBox1.Location = new System.Drawing.Point(573, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(381, 227);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newgridproduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_inventnum);
            this.Controls.Add(this.txt_objectname);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.objectname);
            this.Controls.Add(this.inventorynum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.newgridproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inventorynum;
        private System.Windows.Forms.Label objectname;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_objectname;
        private System.Windows.Forms.TextBox txt_inventnum;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView newgridproduct;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton radiobutton2;
        private System.Windows.Forms.RadioButton raddioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

