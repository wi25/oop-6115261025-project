namespace project_samsung
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.ram = new System.Windows.Forms.Label();
            this.rom = new System.Windows.Forms.Label();
            this.txtram = new System.Windows.Forms.TextBox();
            this.txtrom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Samsung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(168, 142);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(61, 17);
            this.id.TabIndex = 1;
            this.id.Text = "รหัสมือถือ";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(171, 287);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 17);
            this.price.TabIndex = 2;
            this.price.Text = "ราคา";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(174, 182);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(15, 17);
            this.color.TabIndex = 3;
            this.color.Text = "สี";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(174, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(23, 17);
            this.name.TabIndex = 8;
            this.name.Text = "ชื่อ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(243, 102);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(243, 137);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(243, 287);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 22);
            this.txtprice.TabIndex = 11;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(243, 177);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(100, 22);
            this.txtcolor.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 249);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(561, 412);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "เพิ่ม";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(651, 412);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "แก้ไข";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(754, 412);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "ลบ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(561, 465);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 17;
            this.btndisplay.Text = "แสดงผล";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(651, 465);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 18;
            this.btnnext.Text = "ถัดไป";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Location = new System.Drawing.Point(171, 215);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(44, 17);
            this.ram.TabIndex = 19;
            this.ram.Text = "ความจุ";
            // 
            // rom
            // 
            this.rom.AutoSize = true;
            this.rom.Location = new System.Drawing.Point(168, 254);
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(50, 17);
            this.rom.TabIndex = 20;
            this.rom.Text = "ความจำ";
            // 
            // txtram
            // 
            this.txtram.Location = new System.Drawing.Point(243, 215);
            this.txtram.Name = "txtram";
            this.txtram.Size = new System.Drawing.Size(100, 22);
            this.txtram.TabIndex = 21;
            // 
            // txtrom
            // 
            this.txtrom.Location = new System.Drawing.Point(243, 254);
            this.txtrom.Name = "txtrom";
            this.txtrom.Size = new System.Drawing.Size(100, 22);
            this.txtrom.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.Controls.Add(this.txtrom);
            this.Controls.Add(this.txtram);
            this.Controls.Add(this.rom);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.color);
            this.Controls.Add(this.price);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label rom;
        private System.Windows.Forms.TextBox txtram;
        private System.Windows.Forms.TextBox txtrom;
    }
}

