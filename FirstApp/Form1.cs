using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_add_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToInt32(txtBox1.Text);


          if ( num1  >= 50 && num1 < 60){

                MessageBox.Show("انت تقديرك مقبول", "مبروك", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (num1 >= 60 && num1 < 70)
            {
                MessageBox.Show("انت تقديرك جيد", "مبروك", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (num1 >= 70 && num1 < 80)
            {
                MessageBox.Show("انت تقديرك جيد جدا", "مبروك", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (num1 >= 80 && num1 < 90)
            {
                MessageBox.Show("انت تقديرك ممتاز", "مبروك", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (num1 >= 90 )
            {
                MessageBox.Show("انت تقديرك ممتاز مع مرتبة الشرف", "مبروك", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else{
                MessageBox.Show("انت لم تنج يا فاشل ", "حاول مره اخري", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }
    }
}
