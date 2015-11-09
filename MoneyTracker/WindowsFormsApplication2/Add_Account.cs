using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Finisar.SQLite;
using System.Data.SQLite;

namespace WindowsFormsApplication2
{
    public partial class Add_Account : Form
        
    {
        //SQLiteConnection con = new SQLiteConnection("Data Source=D:\\WORK_Vad\\mymoney\\mymoney.db;Version=3;");
        string connection_string = @"Data Source=C:\Users\Vadym\OneDrive\mymoney\mymoney.db;Version=3;";
        //static private MySqlConnection conn = new MySqlConnection("server = 127.0.0.1;uid=gvp;pwd=15945656;database=attendence;");
        static private SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\Vadym\OneDrive\mymoney\mymoney.db;Version=3;");


        public Add_Account()
        {
            InitializeComponent();
            //connection_string = "Data Source = D:\\WORK_Vad\\mymoney\\mymoney.db; Version=3;";
            //con.Open();
            
        
        }
                       
        private void Add_Account_Shown(object sender, EventArgs e)
        {
                 // Fill comboBox:
                 //con.Open();
            SQLiteCommand sc = new SQLiteCommand("select currency_name from currencies;", con);
                 try
                 {
                     SQLiteDataReader dr = sc.ExecuteReader();
                     while (dr.Read())
                     {
                         comboBox_Currency.Items.Add(dr["currency_name"]);
                     }
                     dr.Close();
                     dr.Dispose();
                 }
                 catch (Exception ex)
                 {

                     MessageBox.Show(ex.Message);
                 }
         }

        private void if_new_cur_added(object sender, EventArgs e)
        {
            // Fill comboBox:
            //con.Open();
            //using (SQLiteConnection con = new SQLiteConnection(connection_string))
            {
                try
                {
                    comboBox_Currency.Items.Clear();
                    SQLiteCommand sc = new SQLiteCommand();
                    sc.CommandText = "select currency_name from currencies;";
                    SQLiteDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {

                        comboBox_Currency.Items.Add(dr["currency_name"]);
                    }
                    dr.Close();
                    dr.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                con.Close();
                //con.Dispose();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Currency_Form add_cur = new Add_Currency_Form();
            add_cur.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            using (SQLiteConnection con = new SQLiteConnection(connection_string))
            {
                try
                {

                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = "SELECT c.id FROM currencies c WHERE c.currency_name = @currency_id;";
                    cmd.Parameters.Add(new SQLiteParameter("@currency_id",comboBox_Currency));
                    Int32 currency_id = (Int32)cmd.ExecuteScalar();
                    
                    SQLiteCommand cmd2 = new SQLiteCommand();
                    cmd2.CommandText = "INSERT INTO accounts (account_name, account_descr, currency_id, start_balance, is_in_total) VALUES (@account_name, @account_descr, @currency_id, @start_balance, @is_in_total);";
                    cmd2.Parameters.Add(new SQLiteParameter("@account_name", textBox1_account_name.Text));
                    cmd2.Parameters.Add(new SQLiteParameter("@account_descr", textBox2_account_description.Text));
                    cmd2.Parameters.Add(new SQLiteParameter("@currency_id", currency_id));
                    cmd2.Parameters.Add(new SQLiteParameter("@start_balance", textBox3_start_balance.Text));
                    cmd2.Parameters.Add(new SQLiteParameter("@is_in_total", checkBox1_is_in_total.Text));
                    con.Open();
                    int i = cmd2.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Account added successfully");

                    }
                    //con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
