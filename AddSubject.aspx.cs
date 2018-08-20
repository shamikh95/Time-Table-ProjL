using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class AddSubject : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
            Response.Redirect("Login.aspx");

    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string SCode = TxtSCode .Text;
        string SName = TxtSName .Text;
        //int lec = Convert .ToInt32 (TxtLw.Text);
        string course=DrpCourse .SelectedValue;
        string teacher = TxtTeacher.Text;
        con.Open();
        if (SCode.CompareTo("") != 0 && SName.CompareTo("") != 0 && Convert.ToInt32(TxtLw.Text) != 0 && teacher.CompareTo("") != 0 && course.CompareTo("- Select Course -") != 0)
        {
            cmd = new SqlCommand("Insert Into Subject Values('" + SCode + "','" + SName + "','" + Convert.ToInt32(TxtLw.Text) + "','" + teacher + "','" + course + "')", con);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                LblValid.Text = "Subject Added successfully";
                LblValid.Visible = true;
                TxtSCode.Text = "";
                TxtSName.Text = "";
                TxtLw.Text = "";
                TxtTeacher.Text = "";
                DrpCourse.SelectedValue = "- Select Course -";
            }
            else
            {
                LblValid.Text = "Some Error Occured";
                LblValid.Visible = true;
            }

        }
        else
        {
            Response.Write("<script>alert('Please Fill all the fields ')</script>");
        }
        con.Close();
    }
}