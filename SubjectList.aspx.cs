using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class SubjectList : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    BindData();
        //}
    }
    protected void BindData()
    {
        query = "SELECT * from Subject where Course like '%"+ DrpCourse .SelectedValue +"%'";
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        GridView1.DataSource = dt;
        //GridView1.AllowPaging = true;
       // GridView1.PageSize = 5;
        GridView1.DataBind();
        // GridView1.Columns[7].ItemStyle.ForeColor = Color.Red;

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
        TextBox sc = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1");
        TextBox sn = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2");
        TextBox lw = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3");
        TextBox t = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4");
        int id = Convert.ToInt32(lid.Text);
        con.Open();
        cmd = new SqlCommand("Update Subject set SCode='" + sc.Text + "',SName='" + sn.Text + "',SLecWeek='" + lw.Text + "',Teacher='" + t.Text + "' where SId=" + id, con);
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
        cmd = new SqlCommand("Delete from Subject where SId=" + id, con);
        int res = cmd.ExecuteNonQuery();
        if (res == 1)
        {
            Response.Write("<script>alert('Details deleted successfully ')</script>");
            BindData();
        }

    }
    protected void BtnView_Click(object sender, EventArgs e)
    {
        if (DrpCourse.SelectedValue != "- Select Course -")
        {
            BindData();
            GridView1.Visible = true;
        }
        else
            Response.Write("<script>alert('Please select some course ')</script>");
    }
}
