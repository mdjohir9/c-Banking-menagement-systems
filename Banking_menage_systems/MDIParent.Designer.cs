namespace Banking_menage_systems
{
    partial class MDIParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthdrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthdrowListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountTypeToolStripMenuItem,
            this.customerDataToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.widthdrowToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountTypeToolStripMenuItem
            // 
            this.accountTypeToolStripMenuItem.Name = "accountTypeToolStripMenuItem";
            this.accountTypeToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.accountTypeToolStripMenuItem.Text = "Account Type";
            this.accountTypeToolStripMenuItem.Click += new System.EventHandler(this.accountTypeToolStripMenuItem_Click);
            // 
            // customerDataToolStripMenuItem
            // 
            this.customerDataToolStripMenuItem.Name = "customerDataToolStripMenuItem";
            this.customerDataToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.customerDataToolStripMenuItem.Text = "Customer Data";
            this.customerDataToolStripMenuItem.Click += new System.EventHandler(this.customerDataToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // widthdrowToolStripMenuItem
            // 
            this.widthdrowToolStripMenuItem.Name = "widthdrowToolStripMenuItem";
            this.widthdrowToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.widthdrowToolStripMenuItem.Text = "Widthdrow";
            this.widthdrowToolStripMenuItem.Click += new System.EventHandler(this.widthdrowToolStripMenuItem_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.balanceToolStripMenuItem.Text = "Balance";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem,
            this.depositListToolStripMenuItem,
            this.widthdrowListToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // depositListToolStripMenuItem
            // 
            this.depositListToolStripMenuItem.Name = "depositListToolStripMenuItem";
            this.depositListToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.depositListToolStripMenuItem.Text = "Deposit List";
            this.depositListToolStripMenuItem.Click += new System.EventHandler(this.depositListToolStripMenuItem_Click);
            // 
            // widthdrowListToolStripMenuItem
            // 
            this.widthdrowListToolStripMenuItem.Name = "widthdrowListToolStripMenuItem";
            this.widthdrowListToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.widthdrowListToolStripMenuItem.Text = "Widthdrow List";
            this.widthdrowListToolStripMenuItem.Click += new System.EventHandler(this.widthdrowListToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent";
            this.Text = "Banking Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthdrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthdrowListToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}



