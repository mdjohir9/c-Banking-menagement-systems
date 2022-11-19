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
    public partial class WidthDrow_form : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlstr = "";

        public WidthDrow_form()
        {
            InitializeComponent();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            sqlstr = " Select max (tranNo) + 1 from TranTable";

            Conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {

                text_tranNo.Text = dr1[0].ToString();

            }
            Conn.Close();

            if (text_tranNo.Text == "") text_tranNo.Text = "1001";

            dateTimePicker1.Value = DateTime.Now.Date;

            text_account_no.Text = "";
            text_width_amount.Text = "";
            text_details.Text = "";
            text_remark.Text = "";
            text_account_no.Focus();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {


            if (text_account_no.Text == "")
            {
                MessageBox.Show("Please Enter Account Noumber");
                return;
            }

            int bal = 0;

            sqlstr = " Select sum (depAmt)-sum(withAmt) as BalAmt from tranTable where AcNo=" + text_account_no.Text + "";
            Conn.Open();

            SqlCommand cmd1 = new SqlCommand(sqlstr, Conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                bal = int.Parse(dr1[0].ToString());
            }
            Conn.Close();

            if (bal < int.Parse(text_width_amount.Text))
            {
                MessageBox.Show("You Dont Have a Sufficient Balance");
                return;

            }




            sqlstr = "insert into TranTable values(" + text_tranNo.Text + ",'" + dateTimePicker1.Value + "'," + text_account_no.Text + ",0," +  text_width_amount.Text + ",'" + text_details.Text + "','" + text_remark.Text + "')";

            Conn.Open();
            SqlCommand cmd2 = new SqlCommand(sqlstr, Conn);
            cmd2.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Record Save Successfull");
        }




        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            sqlstr = "select TranNo,AcNo,WithAmt from TranTable where WithAmt > 0 order by TranNo";

            Conn.Open();

            DataSet ds1 = new DataSet();
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstr, Conn);
            sda1.Fill(ds1);
            widthdrow_grid_view.DataSource = ds1.Tables[0];

            Conn.Close();
        }
    }
}
