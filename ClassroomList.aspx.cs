using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class ClassroomList : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        query = "SELECT * from Room";
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        GridView1.DataSource = dt;
        GridView1.AllowPaging = true;
        GridView1.PageSize = 4;
        GridView1.DataBind();
        // GridView1.Columns[7].ItemStyle.ForeColor = Color.Red;

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void edit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindData();
    }
    protected void canceledit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindData();
    }
    protected void update(object sender, GridViewUpdateEventArgs e)
    {
        Label lid = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
        TextBox rn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
        TextBox b = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
        int id = Convert.ToInt32(lid.Text);
        con.Open();
        cmd = new SqlCommand("Update Room set RoomNo='"+ rn .Text +"',RoomBody='"+ b.Text +"' where RoomId=" +id,con);
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.EditIndex = -1;
        Response.Write("<script>alert('Details updated successfully ')</script>");
        BindData();
    }
    protected void delete(object sender, GridViewDeleteEventArgs e)
    {
        Label lid = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
        int id = Convert.ToInt32(lid.Text);
        con.Open();
        cmd = new SqlCommand("Delete from Room where RoomId=" + id, con);
        int res = cmd.ExecuteNonQuery();
        if (res == 1)
        {
            Response.Write("<script>alert('Details deleted successfully ')</script>");
            BindData();
        }

    }
}