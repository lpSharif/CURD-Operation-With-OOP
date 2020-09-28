using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CURD_Form_Applicatin_using_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int customerID;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Insert();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshBoxs();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getCustomerRecord();
        }



        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerID = Convert.ToInt32(CustomerTable.SelectedRows[0].Cells[0].Value);
            idbox.Text = CustomerTable.SelectedRows[0].Cells[0].Value.ToString();
            fstnamebox.Text = CustomerTable.SelectedRows[0].Cells[1].Value.ToString();
            lstnamebox.Text = CustomerTable.SelectedRows[0].Cells[2].Value.ToString();
            agebox.Text = CustomerTable.SelectedRows[0].Cells[3].Value.ToString();
            citybox.Text = CustomerTable.SelectedRows[0].Cells[4].Value.ToString();
        }

    }

}
