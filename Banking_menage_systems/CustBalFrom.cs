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
    public partial class CustBalFrom : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlstr = "";

        public CustBalFrom()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            
            sqlstr = " Select sum (depAmt) - sum(WithAmt) as BalAmt from tranTable where AcNo=" + text_account_no.Text + "";
            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                text_bal_amount.Text=(dr1[0].ToString());
            }
            Conn.Close();

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            text_account_no.Text = "";
            text_bal_amount.Text = "";
            text_account_no.Focus();
        }
    }
}
