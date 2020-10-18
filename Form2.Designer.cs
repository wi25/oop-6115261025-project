namespace project_samsung
{
    partial class Form2
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtphone_number = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(267, 99);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(267, 143);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 1;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(267, 196);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 22);
            this.txtage.TabIndex = 2;
            // 
            // txtphone_number
            // 
            this.txtphone_number.Location = new System.Drawing.Point(267, 240);
            this.txtphone_number.Name = "txtphone_number";
            this.txtphone_number.Size = new System.Drawing.Size(100, 22);
            this.txtphone_number.TabIndex = 3;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(267, 292);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 22);
            this.txtaddress.TabIndex = 4;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(145, 99);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(78, 17);
            this.id.TabIndex = 5;
            this.id.Text = "รหัสพนักงาน";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(145, 143);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 17);
            this.name.TabIndex = 6;
            this.name.Text = "ชื่อพนักงาน";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(145, 196);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(28, 17);
            this.age.TabIndex = 7;
            this.age.Text = "อายุ";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Location = new System.Drawing.Point(145, 240);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(55, 17);
            this.phone_number.TabIndex = 8;
            this.phone_number.Text = "เบอร์โทร";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(145, 292);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(30, 17);
            this.address.TabIndex = 9;
            this.address.Text = "ที่อยู่";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(507, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 215);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(507, 374);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "เพิ่ม";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(629, 374);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "แก้ไข";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(764, 374);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "ลบ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(507, 440);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 14;
            this.btndisplay.Text = "แสดงผล";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnnext.Location = new System.Drawing.Point(629, 439);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 15;
            this.btnnext.Text = "ถัดไป";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "พนักงาน";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone_number);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtphone_number;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label label6;
    }
}