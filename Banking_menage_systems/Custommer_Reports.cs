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
    public partial class Custommer_Reports : Form
    {

        SqlConnection Conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlstr = "";

        public Custommer_Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refrersh_btn_Click(object sender, EventArgs e)
        {
            sqlstr = "select AcNo,cust_name,Cust_adddress,phone_number,email,AcType from customer_table order by AcNo";

            Conn.Open();

            DataSet ds1 = new DataSet();
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstr, Conn);
            sda1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            Conn.Close();

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width=100;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int xPos, yPos;
            xPos = 50;
            yPos = 50;

            Font font1 = new Font("Arial", 30);

            e.Graphics.DrawString("\tUnion Bank Limited", font1, Brushes.Black, xPos, yPos);

            Font font2 = new Font("Arial", 12);
            yPos += 50;

            e.Graphics.DrawString("\t\tJokshin Bazer Sakha Sador,RegNo:78974, Lakshmipur Highway Rode", font2, Brushes.Black, xPos, yPos);

            yPos += 20;
            Pen mypen=new Pen(Color.Black);
            mypen.Width = 2;

            e.Graphics.DrawLine(mypen, xPos,yPos,800,yPos);

            yPos += 100;
            e.Graphics.DrawString("\t Customer Informetions", font1, Brushes.Black, xPos, yPos);

            yPos += 50;
            e.Graphics.DrawLine(mypen, xPos, yPos, 800, yPos);


            yPos += 10;
            e.Graphics.DrawString("Account No", font2, Brushes.Black, xPos, yPos);

            xPos += 100;
            e.Graphics.DrawString("Customer Name", font2, Brushes.Black, xPos, yPos);

            xPos += 200;
            e.Graphics.DrawString("Mobile No", font2, Brushes.Black, xPos, yPos);

            xPos += 150;
            e.Graphics.DrawString("Email", font2, Brushes.Black, xPos, yPos);

            xPos += 150;
            e.Graphics.DrawString("Account Type", font2, Brushes.Black, xPos, yPos);

            yPos += 30;
            e.Graphics.DrawLine(mypen, 50, yPos, 800, yPos);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row .Cells[0].Value !=null)
                {
                    yPos += 50;
                    xPos = 50;
                    e.Graphics.DrawString(row.Cells[0].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 100;
                    e.Graphics.DrawString(row.Cells[1].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 200;
                    e.Graphics.DrawString(row.Cells[2].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 150;
                    e.Graphics.DrawString(row.Cells[3].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 150;
                    e.Graphics.DrawString(row.Cells[4].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                }
            }

        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }



    }
}
