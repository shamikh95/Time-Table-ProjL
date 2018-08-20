using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class DeleteTimeTable : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
            Response.Redirect("Login.aspx");
    }
    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        if (DrpCourse.SelectedIndex >= 0 && DrpCourse.SelectedValue != "- Select Course -")
        {
            //Response.Write("<script>confirm('Do you want to delete the time table ? ')</script>");
            string cnvalue = Request.Form["confirm_value"];
            if (cnvalue != "No")
            {
                cmd = new SqlCommand("Delete from TimeTable  Where Course like '%" +DrpCourse .SelectedValue +"%' ", con);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (cmd.ExecuteNonQuery() != 0)
            {
                Response.Write("<script>alert('Time table deleted successfully. ')</script>");
                con.Close();
                DrpCourse.SelectedIndex = 0;
            }
        }
    }
}