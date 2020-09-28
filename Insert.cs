using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CURD_Form_Applicatin_using_OOP
{
    partial class Form1
    {
        public void Insert()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LPSHARIF;Initial Catalog=Customer;Integrated Security=True");
            if (isVaild())
            {
                SqlCommand cmd = new SqlCommand("insert into Customer values (@firstName, @lastName,@age,@city)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@firstName", fstnamebox.Text);
                cmd.Parameters.AddWithValue("@lastName", lstnamebox.Text);
                cmd.Parameters.AddWithValue("@age", agebox.Text);
                cmd.Parameters.AddWithValue("@city", citybox.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Customer Added Successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getCustomerRecord();
                refreshBoxs();
            }
        }
        private bool isVaild()
        {
            if (fstnamebox.Text == string.Empty)
            {
                MessageBox.Show("Customer's First Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lstnamebox.Text == string.Empty)
            {
                MessageBox.Show("Customer's Last Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (agebox.Text == string.Empty)
            {
                MessageBox.Show("Age is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (citybox.Text == string.Empty)
            {
                MessageBox.Show("City name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}