using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication2
{
    public partial class Add_Currency_Form : Form
    {
        string connection_string;

        public Add_Currency_Form()
        {
            InitializeComponent();
            connection_string = "Data Source = D:\\WORK_Vad\\mymoney\\mymoney.db; Version=3;";
        }

        private void button_save_currency_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connection_string))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = "INSERT INTO currencies (currency_name, currency_name_full) VALUES (@name_char, @full_name);";
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@name_char", textBox1.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@full_name", textBox2.Text));
                    con.Open();

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Currency added successfully");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                  
                }

               
             
            }
        }
    }
}
