using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data ;
using System.Data.SqlClient  ;
using System.Web.UI.WebControls;

public partial class ViewSubjectWise : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr = null;
    protected void Page_Load(object sender, EventArgs e)
    {
       //BindDrpTeacher();
    }
    //protected void BindDrpTeacher()
    //{
    //    con.Open();
    //    cmd = new SqlCommand("SELECT TCode from Teacher", con);
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    DataSet ds = new DataSet();

    //    da.Fill(ds);
    //    con.Close();
    //    DrpTeacher.DataSource = ds;
    //    DrpTeacher.DataTextField = "TCode";
    //   // DrpTeacher.DataValueField = "TCode";
    //    DrpTeacher.DataBind();
    //    //DrpTeacher.Items.Insert(0, new ListItem("- Select Teacher -", "0"));
    //    //L11.Text = ;
    //    //DrpService.Items.Insert(0, new ListItem("- Select Services -", "0"));
    //    //DrpStylist.Items.Insert(0, new ListItem("- Select Stylist -", "0"));
    //}
    private void cleartable()
    {
        L11.Text = L12.Text = L13.Text = L14.Text = L15.Text = L16.Text = "";
        L21.Text = L22.Text = L23.Text = L24.Text = L25.Text = L26.Text = "";
        L31.Text = L32.Text = L33.Text = L34.Text = L35.Text = L36.Text = "";
        L41.Text = L42.Text = L43.Text = L44.Text = L45.Text = L46.Text = "";
        L51.Text = L52.Text = L53.Text = L54.Text = L55.Text = L56.Text = "";
        L61.Text = L62.Text = L63.Text = L64.Text = L65.Text = L66.Text = "";
    }
    protected void BtnView_Click(object sender, EventArgs e)
    {
        cleartable();
       // Panel1.Visible = true;
        //cleartable();
        Label1.Text = DrpTeacher.Text;
       // L11.Text = DrpTeacher.Text ;
        string teacher = DrpTeacher.SelectedValue ;
        if (teacher.CompareTo("- Select Course -") != 0)
        {
            Panel1.Visible = true;
            //cleartable();
            //L11.Text = DrpTeacher.SelectedValue;
            cmd = new SqlCommand("Select * from TimeTable where Teacher like '%" + teacher + "%'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 1)
                {
                    L11.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 2)
                {
                    L12.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 3)
                {
                    L13.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 4)
                {
                    L14.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 5)
                {
                    L15.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 6)
                {
                    L16.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 1)
                {
                    L21.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 2)
                {
                    L22.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 3)
                {
                    L23.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 4)
                {
                    L24.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 5)
                {
                    L25.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 6)
                {
                    L26.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 1)
                {
                    L31.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 2)
                {
                    L32.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 3)
                {
                    L33.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 4)
                {
                    L34.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 5)
                {
                    L35.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 6)
                {
                    L36.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 1)
                {
                    L41.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 2)
                {
                    L42.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 3)
                {
                    L43.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 4)
                {
                    L44.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 5)
                {
                    L45.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 6)
                {
                    L46.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 1)
                {
                    L51.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 2)
                {
                    L52.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 3)
                {
                    L53.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 4)
                {
                    L54.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 5)
                {
                    L55.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 6)
                {
                    L56.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 1)
                {
                    L61.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 2)
                {
                    L62.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 3)
                {
                    L63.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 4)
                {
                    L64.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 5)
                {
                    L65.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
                if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 6)
                {
                    L66.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                }
            }
        }
    }
   
}