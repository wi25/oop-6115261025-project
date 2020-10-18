namespace project_samsung
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtphone_number = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(469, 352);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "เพิ่ม";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(593, 352);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "แก้ไข";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(727, 352);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "ลบ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(469, 413);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 4;
            this.btndisplay.Text = "แสดงผล";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ลูกค้า";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(76, 84);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(60, 17);
            this.id.TabIndex = 7;
            this.id.Text = "รหัสลูกค้า";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(79, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(52, 17);
            this.name.TabIndex = 8;
            this.name.Text = "ชื่อลูกค้า";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(79, 169);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(28, 17);
            this.age.TabIndex = 9;
            this.age.Text = "อายุ";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Location = new System.Drawing.Point(79, 216);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(55, 17);
            this.phone_number.TabIndex = 10;
            this.phone_number.Text = "เบอร์โทร";
            this.phone_number.Click += new System.EventHandler(this.label5_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(82, 259);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(30, 17);
            this.address.TabIndex = 11;
            this.address.Text = "ที่อยู่";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(181, 84);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(181, 130);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 13;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(181, 169);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 22);
            this.txtage.TabIndex = 14;
            // 
            // txtphone_number
            // 
            this.txtphone_number.Location = new System.Drawing.Point(181, 210);
            this.txtphone_number.Name = "txtphone_number";
            this.txtphone_number.Size = new System.Drawing.Size(100, 22);
            this.txtphone_number.TabIndex = 15;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(181, 253);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 22);
            this.txtaddress.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone_number);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtphone_number;
        private System.Windows.Forms.TextBox txtaddress;
    }
}