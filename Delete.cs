using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CURD_Form_Applicatin_using_OOP
{
    partial class Form1
    {
        public void deleteRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LPSHARIF;Initial Catalog=Customer;Integrated Security=True");
            if (customerID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE customerId = @customerId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@customerId", this.customerID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer's Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getCustomerRecord();
                refreshBoxs();

            }
            else
            {
                MessageBox.Show("Please Select A Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
