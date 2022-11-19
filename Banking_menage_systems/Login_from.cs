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
    public partial class Login_from : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlStr= " ";
        public Login_from()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (text_user_name.Text == "")
            {
                MessageBox.Show("Please Enter User Name");
                return;
            }
            if (text_password.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return ;
            }


            Conn.Open();


            sqlStr = "select * from Logindata where user_name='"+text_user_name.Text +"'and password='"+text_password+"'";

            SqlCommand cmd1 = new SqlCommand(sqlStr,Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.Read())
                {
                    Form f1 =new Test_form();
                         f1.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Correct User Name or password");
                }



            Conn.Close();
     

            


        }

        private void Login_from_Load(object sender, EventArgs e)
        {

        }
    }
}
