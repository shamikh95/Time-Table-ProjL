using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class AddTeachers : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string TCode = TxtTCode.Text;
        string TName = TxtTName.Text;
        string quali = TxtTQf.Text;
        string spec = TxtSpec.Text;
       // int lec = Convert.ToInt32(TxtLw.Text);
        con.Open();
        if (TCode.CompareTo("") != 0 && TName.CompareTo("") != 0 && quali.CompareTo("") != 0 && spec.CompareTo("") != 0 )
        {
            cmd = new SqlCommand("Insert Into Teacher(TCode,TName,Qualification,Specialization) Values('" + TCode + "','" + TName + "', '" + quali + "','" + spec + "')", con);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                LblValid.Text = "Teacher Added successfully";
                LblValid.Visible = true;
                TxtTCode.Text = "";
                TxtTName.Text = "";
                TxtSpec.Text = "";
                TxtTQf.Text = "";
                //TxtLw.Text = "";
            }
            else
            {
                LblValid.Text = "Some Error Occured";
                LblValid.Visible = true;
            }

        }
        else
        {
            LblValid.Text = "Fill all the fields";
            LblValid.Visible = true;
        }
        con.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"]==null)
            Response.Redirect("Login.aspx");
        
    }
}