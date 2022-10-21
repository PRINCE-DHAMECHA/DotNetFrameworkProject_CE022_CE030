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
    public partial class Todo : System.Web.UI.Page
    {

        String constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            Label2.Text = Session["username"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            String dt = s_date.Text;
            String ins = "Insert into [Todo](Name,Date,Description) values('" + nametxt.Text + "' , @date, '" + desctxt.Text + "')";
            SqlCommand com = new SqlCommand(ins, con);
            com.Parameters.AddWithValue("@date",dt);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Details.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Response.Redirect("/Login.aspx");
        }
    }
}