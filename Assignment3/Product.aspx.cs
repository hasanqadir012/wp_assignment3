using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment3
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connection_string = System.Configuration.ConfigrationManager.ConnextionStrings["conn"].ConnectionString;
                SqlConnection connection = new SqlConnection(connection_string);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from products", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridView1.DataSource = table;
                GridView1.DataBind();

            }
        }
    }
}