using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CURD_Form_Applicatin_using_OOP
{
    partial class Form1
    {
        public void update()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LPSHARIF;Initial Catalog=Customer;Integrated Security=True");
            if (customerID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET firstName = @firstName, lastName = @lastName,age = @age,city = @city WHERE customerId = @customerId", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@firstName", fstnamebox.Text);
                cmd.Parameters.AddWithValue("@lastName", lstnamebox.Text);
                cmd.Parameters.AddWithValue("@age", agebox.Text);
                cmd.Parameters.AddWithValue("@city", citybox.Text);
                cmd.Parameters.AddWithValue("@customerId", this.customerID);

                bool ok = executeable();

                if (ok)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer's Details Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getCustomerRecord();
                    refreshBoxs();
                }
                else
                {
                    MessageBox.Show("Can't Change Customer ID :(", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Select A Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool executeable()
        {
            if (customerID == Convert.ToInt32(idbox.Text))
            {
                return true;
            }
            return false;
        }


    }


}
