using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace FirstApp
{
    public partial class Form1 : Form{

        int num1 = 4, num2 = 10 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            NUDAge.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection CONN = new SqlConnection("Data Source=OS;Initial Catalog=FirstDatabase;Integrated Security=True");

            SqlCommand cmmd = new SqlCommand();

            cmmd.Connection = CONN;
            cmmd.CommandText = "select * from Students where id="+txtID.Text+"";
            clearFields();

            CONN.Open();

            DataTable table = new DataTable();
            table.Load(cmmd.ExecuteReader());

            txtID.Text = Convert.ToString(table.Rows[0][0]);
            txtName.Text = table.Rows[0][1].ToString();
            txtPhone.Text = table.Rows[0][2].ToString();
            txtAddress.Text = table.Rows[0][3].ToString();
            NUDAge.Value = Convert.ToDecimal(table.Rows[0][4]);
   
            MessageBox.Show("تم جلب البيانات بنجاح");
            CONN.Close();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection CONN = new SqlConnection("Data Source=OS;Initial Catalog=FirstDatabase;Integrated Security=True");

            SqlCommand cmmd = new SqlCommand();

            cmmd.Connection = CONN;
            cmmd.CommandText = "select * from Students where id=" + txtID.Text + "";
            clearFields();

            CONN.Open();

            DataTable table = new DataTable();
            table.Load(cmmd.ExecuteReader());

            txtID.Text = Convert.ToString(table.Rows[0][0]);
            txtName.Text = table.Rows[0][1].ToString();
            txtPhone.Text = table.Rows[0][2].ToString();
            txtAddress.Text = table.Rows[0][3].ToString();
            NUDAge.Value = Convert.ToDecimal(table.Rows[0][4]);

            MessageBox.Show("تم جلب البيانات بنجاح");
            CONN.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection CONN = new SqlConnection("Data Source=OS;Initial Catalog=FirstDatabase;Integrated Security=True");

            SqlCommand cmmd = new SqlCommand();

            cmmd.Connection = CONN;
            cmmd.CommandText = "select id as 'كود الطالب' , name as 'اسم الطالب', phone as 'رقم تليفون الطالب', address as 'العنوان' , age as 'العمر' from Students";
            clearFields();

            CONN.Open();

            DataTable table = new DataTable();
            table.Load(cmmd.ExecuteReader());

            dataGridView1.DataSource = table;

            CONN.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            /*   SqlConnection CONN = new SqlConnection("Data Source=OS;Initial Catalog=FirstDatabase;Integrated Security=True");

              SqlCommand cmmd = new SqlCommand();

              cmmd.Connection = CONN;
              cmmd.CommandText = "insert into Students values ("+txtID.Text+" , '"+txtName.Text+ "' , '"+txtPhone.Text+ "' , '"+txtAddress.Text+ "' , "+NUDAge.Text+ ")";
              clearFields();

              CONN.Open();
              cmmd.ExecuteNonQuery();
              MessageBox.Show("تم الحفظ بنجاح");
              CONN.Close(); */

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\FirstDB.accdb");
            OleDbCommand cmmd = new OleDbCommand();

            cmmd.Connection = conn;
            cmmd.CommandText = "insert into Students values (" + txtID.Text + " , '" + txtName.Text + "' , '" + txtPhone.Text + "' , '" + txtAddress.Text + "' , " + NUDAge.Text + ")";

            clearFields();
            conn.Open();

            cmmd.ExecuteNonQuery();
            MessageBox.Show("تم حفظ البيانات ", "تأكيد");

            conn.Close();


        }
    }
}
