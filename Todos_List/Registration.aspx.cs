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
    public partial class Registration : System.Web.UI.Page
    {
        String constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                String ins = "Insert into [Register](Name, Email_Id,Password,Mobile) values('" + nametxt.Text + "', '" + emailtxt.Text + "' , '" + passtxt.Text + "', '" + mobiletxt.Text + "')";
                SqlCommand com = new SqlCommand(ins, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Login.aspx");
            }
            catch(Exception err)
            {
                Response.Write("Error in Register"+ err); 
            }
        }
    }
}