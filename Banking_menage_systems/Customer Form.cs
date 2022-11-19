using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
namespace Banking_menage_systems
{
    public partial class Customer_Form : Form
    {
        SqlConnection Conn=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlStr = "";
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            Combo_AccountType.Items.Clear();
            sqlStr = " Select ACTypeName from ACTypeTable order by ACTypeName";
            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                Combo_AccountType.Items.Add(dr1[0].ToString());
            }
            Conn.Close();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            text_Acount.Text = "";
            text_cust_name.Text = "";
            text_address.Text = "";
            text_mobile_no.Text = "";
            text_emailId.Text = "";
            Combo_AccountType.Text = "";
            text_Acount.Focus();

            button_new.Enabled = false;
            buttonSave.Enabled = true;
            buttonUpdate.Enabled = false;
            button_Delate.Enabled = false;

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (text_Acount.Text == "")
            {
                MessageBox.Show("Please Enter Account Type");
                return;
            }

            if (text_cust_name.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name");
                return;
            }

            string Pattern = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";


            if (Regex.IsMatch(text_emailId.Text, Pattern) == false)
            {
                MessageBox.Show("Not a valid Email ID");
                return;
            }

            sqlStr = "insert into customer_table values(" + text_Acount.Text + ",'" + text_cust_name.Text + "','" + text_address.Text + "','" + text_mobile_no.Text + "','" + text_emailId.Text + "','" + Combo_AccountType.Text + "')";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Conn);
            cmd1.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Save Successfull");

            button_new.Enabled = true;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = false;
            button_Delate.Enabled = false;

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            sqlStr = "select AcNo,cust_name from customer_table order by AcNo";

            Conn.Open();
           
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlStr, Conn);
            sda1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            Conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string t1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            
            sqlStr = " Select * from customer_table where AcNo=" + t1+"";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {

                text_Acount.Text=dr1[0].ToString();
                text_cust_name.Text = dr1[1].ToString();
                text_address.Text = dr1[2].ToString();
                text_mobile_no.Text = dr1[3].ToString();
                text_emailId.Text = dr1[4].ToString();
                Combo_AccountType.Text = dr1[5].ToString();
            }
            Conn.Close();

            button_new.Enabled = true;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            button_Delate.Enabled = true;
        }

        private void button_Delate_Click(object sender, EventArgs e)
        {
            if (text_Acount.Text == "")
            {
                MessageBox.Show("Please Enter Account Type");
                return;
            } 

            sqlStr = "Delete From customer_table where AcNo='" + text_Acount.Text + "'";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Conn);
            cmd1.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Delete Successfull");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (text_Acount.Text == "")
            {
                MessageBox.Show("Please Enter Detalis");
                return;
            }

            sqlStr = "update customer_table set cust_name='" + text_cust_name.Text + "',Cust_adddress='" + text_address.Text + "',phone_number='" + text_mobile_no.Text + "',email='" + text_emailId.Text + "', cust_name='" + text_cust_name.Text + "' where AcNo='" + text_Acount.Text + "'";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, Conn);
            cmd1.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Updated Successfull");

            button_new.Enabled = true;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = false;
            button_Delate.Enabled = false;
        }

        private void text_mobile_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            int var1=(int)(e.KeyChar);
            if (var1 == 8) return;
            if (var1 < 48 || var1 > 57)
            {
                MessageBox.Show("Please Enter The Number");
                e.Handled = true;
            }

        }
    }
}

