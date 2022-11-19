using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking_menage_systems

{
    public partial class Withdrow_report : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Banking_database.mdf;Integrated Security=True;Connect Timeout=30");
        string sqlstr = "";
        public Withdrow_report()
        {
            InitializeComponent();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}



        private void button3_Click(object sender, EventArgs e)
        {
            sqlstr = "select tranNo, tranDate, AcNo, WithAmt,detalis,Rem1 from TranTable where WithAmt > 0 order by tranNo";

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
            dataGridView1.Columns[5].Width = 200;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void print_btn(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            Pen mypen = new Pen(Color.Black);
            mypen.Width = 2;

            e.Graphics.DrawLine(mypen, xPos, yPos, 800, yPos);

            yPos += 40;
            xPos += 200;
            Font font3 = new Font("Arial", 22);
            e.Graphics.DrawString("Withdrow Informetions", font3, Brushes.Black, xPos, yPos);

            yPos += 50;
            e.Graphics.DrawLine(mypen, xPos = 40, yPos, 800, yPos);


            yPos += 10;
            e.Graphics.DrawString("Tran No", font2, Brushes.Black, xPos, yPos);

            xPos += 100;
            e.Graphics.DrawString("Tran Date", font2, Brushes.Black, xPos, yPos);

            xPos += 200;
            e.Graphics.DrawString("Account No", font2, Brushes.Black, xPos, yPos);

            xPos += 100;
            e.Graphics.DrawString("With Amount", font2, Brushes.Black, xPos, yPos);

            xPos += 120;
            e.Graphics.DrawString("Details", font2, Brushes.Black, xPos, yPos);

            xPos += 120;
            e.Graphics.DrawString("Remark", font2, Brushes.Black, xPos, yPos);


            yPos += 30;
            e.Graphics.DrawLine(mypen, 50, yPos, 800, yPos);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    yPos += 50;
                    xPos = 50;
                    e.Graphics.DrawString(row.Cells[0].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 100;
                    e.Graphics.DrawString(row.Cells[1].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 200;
                    e.Graphics.DrawString(row.Cells[2].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 100;
                    e.Graphics.DrawString(row.Cells[3].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 120;
                    e.Graphics.DrawString(row.Cells[4].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                    xPos += 120;
                    e.Graphics.DrawString(row.Cells[5].Value.ToString(), font2, Brushes.Black, xPos, yPos);

                }
            }

        }
    
    }
}
