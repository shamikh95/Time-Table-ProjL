using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class AddClass : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
            Response.Redirect("Login.aspx");

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string RNo = TxtRoomNo.Text;
        string Body = TxtSumm.Text;
        con.Open();
        if (RNo.CompareTo("") != 0 && Body.CompareTo("") != 0)
        {
            cmd = new SqlCommand("Insert Into Room Values('" + RNo + "','" + Body + "')", con);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                LblValid.Text = "Room Created successfully";
                LblValid.Visible = true;
                TxtSumm.Text = "";
                TxtRoomNo.Text = "";
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
}