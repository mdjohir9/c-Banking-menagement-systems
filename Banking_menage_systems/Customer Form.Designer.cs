namespace Banking_menage_systems
{
    partial class Customer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_mobile_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_cust_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Acount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_AccountType = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button_Delate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_emailId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(572, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // text_address
            // 
            this.text_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_address.Location = new System.Drawing.Point(287, 223);
            this.text_address.Multiline = true;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(264, 93);
            this.text_address.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // text_mobile_no
            // 
            this.text_mobile_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_mobile_no.Location = new System.Drawing.Point(287, 353);
            this.text_mobile_no.MaxLength = 10;
            this.text_mobile_no.Multiline = true;
            this.text_mobile_no.Name = "text_mobile_no";
            this.text_mobile_no.Size = new System.Drawing.Size(264, 28);
            this.text_mobile_no.TabIndex = 4;
            this.text_mobile_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_mobile_no_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile number";
            // 
            // text_cust_name
            // 
            this.text_cust_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_cust_name.Location = new System.Drawing.Point(287, 162);
            this.text_cust_name.Multiline = true;
            this.text_cust_name.Name = "text_cust_name";
            this.text_cust_name.Size = new System.Drawing.Size(264, 28);
            this.text_cust_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cust Name";
            // 
            // text_Acount
            // 
            this.text_Acount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_Acount.Location = new System.Drawing.Point(287, 102);
            this.text_Acount.Multiline = true;
            this.text_Acount.Name = "text_Acount";
            this.text_Acount.Size = new System.Drawing.Size(140, 28);
            this.text_Acount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acount No";
            // 
            // Combo_AccountType
            // 
            this.Combo_AccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo_AccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_AccountType.FormattingEnabled = true;
            this.Combo_AccountType.Location = new System.Drawing.Point(287, 459);
            this.Combo_AccountType.Name = "Combo_AccountType";
            this.Combo_AccountType.Size = new System.Drawing.Size(264, 24);
            this.Combo_AccountType.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(193, 509);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(72, 33);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button_Delate
            // 
            this.button_Delate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Delate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delate.Location = new System.Drawing.Point(291, 509);
            this.button_Delate.Name = "button_Delate";
            this.button_Delate.Size = new System.Drawing.Size(72, 33);
            this.button_Delate.TabIndex = 10;
            this.button_Delate.Text = "Delate";
            this.button_Delate.UseVisualStyleBackColor = true;
            this.button_Delate.Click += new System.EventHandler(this.button_Delate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(384, 509);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(72, 33);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button_new
            // 
            this.button_new.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.Location = new System.Drawing.Point(478, 509);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(72, 33);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(936, 605);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(72, 33);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrefresh.Location = new System.Drawing.Point(459, 101);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(72, 33);
            this.buttonrefresh.TabIndex = 12;
            this.buttonrefresh.Text = "Refresh";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(667, 509);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(72, 33);
            this.buttonDisplay.TabIndex = 9;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email ID";
            // 
            // text_emailId
            // 
            this.text_emailId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_emailId.Location = new System.Drawing.Point(287, 409);
            this.text_emailId.Multiline = true;
            this.text_emailId.Name = "text_emailId";
            this.text_emailId.Size = new System.Drawing.Size(264, 28);
            this.text_emailId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Account Type";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(337, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 37);
            this.label7.TabIndex = 52;
            this.label7.Text = "Customer Informetions";
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 640);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button_Delate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.Combo_AccountType);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_emailId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_mobile_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_cust_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Acount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_mobile_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_cust_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Acount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_AccountType;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button_Delate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_emailId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}