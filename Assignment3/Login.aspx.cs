using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username == "admin" && password == "123")
            {
                Session["username"] = "admin";
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Session["username"] = username;
                Response.Redirect("Product.aspx");
            }

        }
    }
}