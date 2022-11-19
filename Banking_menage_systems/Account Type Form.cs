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

namespace Banking_menage_systems
{
    public partial class Account_Type_Form : Form
    {
        SqlConnection Conn= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlstr = "";


        public Account_Type_Form()
        {
            InitializeComponent();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            text_aaount_type.Text = "";
            text_detalis.Text = "";
            text_aaount_type.Focus();

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (text_aaount_type.Text == "")
            {
                MessageBox.Show("Please Enter Account Type");
                return;
            }
            if (text_detalis.Text == "")
            {
                MessageBox.Show("Please Enter Detalis");
                return;
            }
            sqlstr = "insert into ACTypeTable values('"+text_aaount_type.Text+"','"+text_detalis.Text+"')";

            Conn.Open();
            SqlCommand cmd1 =new SqlCommand(sqlstr,Conn);
            cmd1.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Save Successfull");

        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            sqlstr = " Select ACTypeName from ACTypeTable order by ACTypeName";
            Conn.Open();
            SqlCommand cmd1 =new SqlCommand(sqlstr,Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0].ToString());
            }
            Conn.Close();


    
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            sqlstr = "Select AcNo,Cust_name from ACTypeNAme='" + comboBox1.Text + "'";
            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                text_aaount_type.Text=dr1[0].ToString();
                text_detalis.Text = dr1[1].ToString();
            }
            Conn.Close();


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (text_aaount_type.Text == "")
            {
                MessageBox.Show("Please Enter Account Type");
                return;
            }
            if (text_detalis.Text == "")
            {
                MessageBox.Show("Please Enter Detalis");
                return;
            }

            sqlstr = "update ACTypeTable set Detalis='" + text_detalis.Text + "' where ACTypeName='" + text_aaount_type.Text + "'";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Updated Successfull");

        }



        private void Account_Type_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_Delate_Click_1(object sender, EventArgs e)
        {
            if (text_aaount_type.Text == "")
            {
                MessageBox.Show("Please Enter Account Type");
                return;
            }
            if (text_detalis.Text == "")
            {
                MessageBox.Show("Please Enter Detalis");
                return;
            }

            sqlstr = "Delete From ACTypeTable where ACTypeName='" + text_aaount_type.Text + "'";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            cmd1.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Delete Successfull");
        }
    }
    
}
