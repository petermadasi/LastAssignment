using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Last_Assignment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\assignment.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void single_Click(object sender, EventArgs e)
        {
            string qry = "select * from lap  where id='" + id.Text+ "' ";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = qry;
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            name.Text = dt.Rows[0]["Name"].ToString();
            price.Text = dt.Rows[0]["Price"].ToString();
            count.Text = dt.Rows[0]["Count"].ToString();
            total.Text = dt.Rows[0]["TotalPrice"].ToString();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string qry = "update lap set Name='" + name.Text + "',Pic='" +fu_pic.HasFile.ToString() + "',Price='" + price.Text + "',Count='" + count.Text + "',TotalPrice='" + total.Text + "' where Id='" + id.Text + "' ";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = qry;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("WebForm1.aspx");
        }
    }
}