using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        TxtName .Focus ();
        
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string unm = TxtName .Text;
        string pwd = TxtPwd.Text;
        int flag = 0;
        con.Open();
        cmd = new SqlCommand("Select * From Admin Where Username='" + unm + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            dr.Read();
            Session["uname"] = unm;
            if (dr["Pwd"].ToString().CompareTo(pwd) != 0)
                flag = 2;
        }
        else
            flag = 1;

        dr.Close();
        con.Close();
        if (flag == 0)
        {
            if (Session["uname"] == null)
            {
                TxtName.Text = "";
                TxtPwd.Text = "";
                Response.Redirect("Login.aspx");
            }
            else
            {
                TxtName.Text = "";
                LblValid.Visible = true;
                LblValid.Text = "Welcome " + unm + " !!";
            }
                //Response.Redirect("Home.aspx");
        }
        else if (flag == 1)
        {
            LblValid.Visible = true;
            LblValid.Text = "Invalid User Name";
            TxtName.Focus();
        }
        else
        {
            LblValid.Visible = true;
            LblValid.Text = "Invalid Password";
            TxtPwd.Focus();
        }
        
        Session.Remove("uid");
    }
}