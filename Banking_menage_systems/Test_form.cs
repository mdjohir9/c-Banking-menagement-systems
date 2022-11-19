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
    public partial class Test_form : Form
    {
        public Test_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Test_form_Load(object sender, EventArgs e)
        {

        }

        private void button_colse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_customer_code.Text = "";
            textBox_customer_name.Text = "";
            textBox_address.Text = "";
            textBox_mobile.Text = "";
        }
    }
}
