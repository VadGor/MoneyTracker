namespace WindowsFormsApplication2
{
    partial class Add_Currency_Form
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
            this.label_3symbol_currency_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_full_currency_name = new System.Windows.Forms.Label();
            this.button_save_currency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_3symbol_currency_name
            // 
            this.label_3symbol_currency_name.AutoSize = true;
            this.label_3symbol_currency_name.Location = new System.Drawing.Point(23, 24);
            this.label_3symbol_currency_name.Name = "label_3symbol_currency_name";
            this.label_3symbol_currency_name.Size = new System.Drawing.Size(133, 13);
            this.label_3symbol_currency_name.TabIndex = 0;
            this.label_3symbol_currency_name.Text = "Currency name (3 symbols)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label_full_currency_name
            // 
            this.label_full_currency_name.AutoSize = true;
            this.label_full_currency_name.Location = new System.Drawing.Point(23, 69);
            this.label_full_currency_name.Name = "label_full_currency_name";
            this.label_full_currency_name.Size = new System.Drawing.Size(96, 13);
            this.label_full_currency_name.TabIndex = 2;
            this.label_full_currency_name.Text = "Full currency name";
            // 
            // button_save_currency
            // 
            this.button_save_currency.Location = new System.Drawing.Point(175, 129);
            this.button_save_currency.Name = "button_save_currency";
            this.button_save_currency.Size = new System.Drawing.Size(120, 23);
            this.button_save_currency.TabIndex = 4;
            this.button_save_currency.Text = "Save currency";
            this.button_save_currency.UseVisualStyleBackColor = true;
            this.button_save_currency.Click += new System.EventHandler(this.button_save_currency_Click);
            // 
            // Add_Currency_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 193);
            this.Controls.Add(this.button_save_currency);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_full_currency_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_3symbol_currency_name);
            this.Name = "Add_Currency_Form";
            this.Text = "Add Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_3symbol_currency_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_full_currency_name;
        private System.Windows.Forms.Button button_save_currency;
    }
}