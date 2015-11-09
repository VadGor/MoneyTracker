namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Add_New_Transaction = new System.Windows.Forms.Button();
            this.tabPage3_Current_balance = new System.Windows.Forms.TabPage();
            this.btn_Add_New_Account = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3_Current_balance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3_Current_balance);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 209);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current balance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 141);
            this.dataGridView1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_Add_New_Transaction);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 141);
            this.dataGridView2.TabIndex = 5;
            // 
            // btn_Add_New_Transaction
            // 
            this.btn_Add_New_Transaction.Location = new System.Drawing.Point(6, 154);
            this.btn_Add_New_Transaction.Name = "btn_Add_New_Transaction";
            this.btn_Add_New_Transaction.Size = new System.Drawing.Size(123, 23);
            this.btn_Add_New_Transaction.TabIndex = 4;
            this.btn_Add_New_Transaction.Text = "Add new transaction";
            this.btn_Add_New_Transaction.UseVisualStyleBackColor = true;
            this.btn_Add_New_Transaction.Click += new System.EventHandler(this.btn_Add_New_Transaction_Click);
            // 
            // tabPage3_Current_balance
            // 
            this.tabPage3_Current_balance.Controls.Add(this.btn_Add_New_Account);
            this.tabPage3_Current_balance.Controls.Add(this.dataGridView3);
            this.tabPage3_Current_balance.Location = new System.Drawing.Point(4, 22);
            this.tabPage3_Current_balance.Name = "tabPage3_Current_balance";
            this.tabPage3_Current_balance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3_Current_balance.Size = new System.Drawing.Size(535, 183);
            this.tabPage3_Current_balance.TabIndex = 2;
            this.tabPage3_Current_balance.Text = "Accounts";
            this.tabPage3_Current_balance.UseVisualStyleBackColor = true;
            // 
            // btn_Add_New_Account
            // 
            this.btn_Add_New_Account.Location = new System.Drawing.Point(6, 153);
            this.btn_Add_New_Account.Name = "btn_Add_New_Account";
            this.btn_Add_New_Account.Size = new System.Drawing.Size(123, 23);
            this.btn_Add_New_Account.TabIndex = 6;
            this.btn_Add_New_Account.Text = "Add new account";
            this.btn_Add_New_Account.UseVisualStyleBackColor = true;
            this.btn_Add_New_Account.Click += new System.EventHandler(this.btn_Add_New_Account_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(243, 141);
            this.dataGridView3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 309);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3_Current_balance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Add_New_Transaction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3_Current_balance;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_Add_New_Account;
    }
}

