using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Todos_List
{
    public partial class Details : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            usrnm.Text = Session["username"].ToString();
            String constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            String cmdx = "select * from Todo";
            SqlCommand cmd = new SqlCommand(cmdx,con);
            con.Open();
            SqlDataReader rdr2 = cmd.ExecuteReader();
            GridView1.DataSource = rdr2;
            GridView1.DataBind();
            rdr2.Close();
           
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Response.Redirect("/Login.aspx");
        }

        protected void Buttun1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Todo.aspx");
        }
    }
}