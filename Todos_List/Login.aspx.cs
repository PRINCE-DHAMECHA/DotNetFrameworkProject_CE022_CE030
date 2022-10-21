using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Todos_List
{
    public partial class Login : System.Web.UI.Page
    {
        String constr= ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string check = "select count(*) from [Register] where Email_Id = '" + usertxt.Text + "' and Password = '" + passtxt.Text + "'";
            SqlCommand com = new SqlCommand(check, con);
            con.Open();
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.HasRows)
            {
                Session["username"] = usertxt.Text;
                Response.Write("Login Successful!!!");
                Response.Redirect("/Details.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid credentials')</script>");
            }
       
        }
    }
}