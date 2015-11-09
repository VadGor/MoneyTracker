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
    public partial class Form1 : Form
    {
        static string filepath = System.IO.Path.Combine(Application.StartupPath + "\\BD\\mymoney.db");
           // filepath = System.IO.Path.Combine(Application.StartupPath + "\\BD\\mymoney.db");
        //SQLiteConnection con = new SQLiteConnection(@"Data Source=" + filepath + ";Version=3;");
        //SQLiteConnection con = new SQLiteConnection(@"Data Source=" + filepath + ";Version=3;");
        SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\Programming\GitHub\MoneyTracker\MoneyTracker\WindowsFormsApplication2\bin\x86\Debug\DB\mymoney.db;Version=3;");
        SQLiteDataAdapter da1;
        DataTable dt1 = new DataTable();
        SQLiteDataAdapter da2;
        DataTable dt2 = new DataTable();
        SQLiteDataAdapter da3;
        DataTable dt3 = new DataTable();

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(con.ConnectionString);
        }
        private void Show_current_balance()
        {
            //dt.Clear();
            string command = "SELECT * FROM [current_balance];";
            da1 = new SQLiteDataAdapter(command, con);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
        private void Show_transactions()
        {
            //dt.Clear();
            string command = "SELECT * FROM transactions;";
            //string command = "SELECT datetime();";
            da2 = new SQLiteDataAdapter(command, con);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }
        private void Show_accounts()
        {
            //dt.Clear();
            string command = "SELECT * FROM accounts;";
            da3 = new SQLiteDataAdapter(command, con);
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

        }     
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //private void btn_Add_New_Account_Click(object sender, EventArgs e)
        //{
        //    Add_Account add_acc = new Add_Account();
        //    add_acc.ShowDialog();
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            Show_current_balance();
            Show_transactions();
            Show_accounts();
        }
        private void btn_Add_New_Account_Click_1(object sender, EventArgs e)
        {
            Add_Account add_acc = new Add_Account();
            add_acc.ShowDialog();

        }
        private void btn_Add_New_Transaction_Click(object sender, EventArgs e)
        {
            Add_Transaction add_tran = new Add_Transaction();
            add_tran.ShowDialog();
        }
    }
}
