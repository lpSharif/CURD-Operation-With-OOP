using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CURD_Form_Applicatin_using_OOP
{
    partial class Form1
    {
        private void getCustomerRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LPSHARIF;Initial Catalog=Customer;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Customer", con);
            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CustomerTable.DataSource = dt;
        }
    }
}
