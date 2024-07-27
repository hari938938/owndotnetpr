using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dotnetpr1
{
    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            // Define your connection string here
            string connectionString = ConfigurationManager.ConnectionStrings["My Connection String"].ConnectionString;

            // Create a new SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //string insertQuery = "INSERT INTO dbo.emp_table (empID, empName, email) VALUES (@Value1, @Value2, @Value3)";

                    string storedProcedureName = "InsertEmployee";
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        //command.Parameters.AddWithValue("@Value1", txtid.Text);
                        //command.Parameters.AddWithValue("@Value2", txtname.Text);
                        //command.Parameters.AddWithValue("@Value3", txtemail.Text);

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@empID", (txtid.Text));
                        command.Parameters.AddWithValue("@empName", txtname.Text);
                        command.Parameters.AddWithValue("@email", txtemail.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Output the result to the webpage
                        Response.Write($"{rowsAffected} rows inserted.");
                    }
                }
                catch (Exception ex)
                {
                    // Output the error message to the webpage
                    Response.Write("An error occurred: " + ex.Message);
                }
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
            {
                txtid.Text = "";
                txtname.Text = "";
                txtemail.Text = "";
            }
        }
    }

   
