using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_menage_systems
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void accountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Account_Type_Form();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;

            f1.Show();

        }

        private void customerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Customer_Form();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;

            f1.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Deposit_Form();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;

            f1.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new CustBalFrom();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;

            f1.Show();
        }

        private void widthdrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new WidthDrow_form();
            f1.MdiParent= this;
            f1.WindowState = FormWindowState.Maximized;
            f1.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Custommer_Reports();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f1.Show();
        }

        private void depositListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Deposit_report_form();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f1.Show();
        }

        private void widthdrowListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new Withdrow_report();
            f1.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f1.Show();
        }
    }
}
