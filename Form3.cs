using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace project_samsung
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=phone_samsung";

                string Query = "insert into customers(name,age,phone_number,address) " +
                    "values('" + this.txtname.Text + "','" + this.txtage.Text + "','" + this.txtphone_number.Text + "','" + this.txtaddress.Text + "');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=phone_samsung";


                string Query = "update customers set name='" + this.txtname.Text + "',age='" + this.txtage.Text + "',phone_number='" + this.txtphone_number.Text + "',address='" + this.txtaddress.Text + "' where id'" + this.txtid.Text + "';";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=phone_samsung";

                string Query = "delete from customers where name'" + this.txtname.Text + "',age'" + this.txtage.Text + "',phone_number'" + this.txtphone_number.Text + "',address'" + this.txtaddress.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=phone_samsung";
                string Query = "select * from customers;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                dataGridView1.DataSource = dTable;



                // MyConn2.Close(); 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }
    }
}