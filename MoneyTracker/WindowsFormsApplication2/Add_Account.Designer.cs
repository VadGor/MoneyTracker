namespace WindowsFormsApplication2
{
    partial class Add_Account
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_account_name = new System.Windows.Forms.TextBox();
            this.textBox2_account_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1_is_in_total = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3_start_balance = new System.Windows.Forms.TextBox();
            this.comboBox_Currency = new System.Windows.Forms.ComboBox();
            this.sQLiteTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name *";
            // 
            // textBox1_account_name
            // 
            this.textBox1_account_name.AccessibleDescription = "";
            this.textBox1_account_name.Location = new System.Drawing.Point(130, 5);
            this.textBox1_account_name.Name = "textBox1_account_name";
            this.textBox1_account_name.Size = new System.Drawing.Size(515, 20);
            this.textBox1_account_name.TabIndex = 1;
            this.textBox1_account_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_account_description
            // 
            this.textBox2_account_description.Location = new System.Drawing.Point(130, 39);
            this.textBox2_account_description.Name = "textBox2_account_description";
            this.textBox2_account_description.Size = new System.Drawing.Size(515, 20);
            this.textBox2_account_description.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Валюта *";
            // 
            // checkBox1_is_in_total
            // 
            this.checkBox1_is_in_total.AutoSize = true;
            this.checkBox1_is_in_total.Checked = true;
            this.checkBox1_is_in_total.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1_is_in_total.Location = new System.Drawing.Point(16, 160);
            this.checkBox1_is_in_total.Name = "checkBox1_is_in_total";
            this.checkBox1_is_in_total.Size = new System.Drawing.Size(141, 17);
            this.checkBox1_is_in_total.TabIndex = 5;
            this.checkBox1_is_in_total.Text = "included in total balance";
            this.checkBox1_is_in_total.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Начальный баланс *";
            // 
            // textBox3_start_balance
            // 
            this.textBox3_start_balance.Location = new System.Drawing.Point(130, 85);
            this.textBox3_start_balance.Name = "textBox3_start_balance";
            this.textBox3_start_balance.Size = new System.Drawing.Size(126, 20);
            this.textBox3_start_balance.TabIndex = 7;
            this.textBox3_start_balance.Text = "0,00";
            this.textBox3_start_balance.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox_Currency
            // 
            this.comboBox_Currency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sQLiteTransactionBindingSource, "Connection", true));
            this.comboBox_Currency.DisplayMember = "Connection";
            this.comboBox_Currency.FormattingEnabled = true;
            this.comboBox_Currency.Location = new System.Drawing.Point(130, 116);
            this.comboBox_Currency.Name = "comboBox_Currency";
            this.comboBox_Currency.Size = new System.Drawing.Size(126, 21);
            this.comboBox_Currency.TabIndex = 8;
            this.comboBox_Currency.ValueMember = "Connection";
            this.comboBox_Currency.SelectedIndexChanged += new System.EventHandler(this.comboBox_Currency_SelectedIndexChanged);
            this.comboBox_Currency.Click += new System.EventHandler(this.if_new_cur_added);
            // 
            // sQLiteTransactionBindingSource
            // 
            this.sQLiteTransactionBindingSource.DataSource = typeof(Finisar.SQLite.SQLiteTransaction);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add new currency";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 257);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Currency);
            this.Controls.Add(this.textBox3_start_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1_is_in_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_account_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_account_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_Account";
            this.Text = "Add_Account";
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_account_name;
        private System.Windows.Forms.TextBox textBox2_account_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1_is_in_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3_start_balance;
        private System.Windows.Forms.ComboBox comboBox_Currency;
        private System.Windows.Forms.BindingSource sQLiteTransactionBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}