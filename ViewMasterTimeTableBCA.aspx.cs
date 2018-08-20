using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class ViewMasterTimeTableBCA : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr = null;
    //protected void ft()
    //{
    //    cmd = new SqlCommand("Select * from TimeTable where Course like '%BCA%' and Room='LAB'", con);
    //    if (con.State == ConnectionState.Closed)
    //    {
    //        con.Open();
    //    }
    //}
    protected void BtnView_Click(object sender, EventArgs e)
    {
        //Panel2.Visible = true;
        string course = DrpCourse.SelectedValue;
        if (course.CompareTo("- Select Course -") != 0)
        {
            if (course == "BCA")
            {
                   
                Panel1.Visible = true;
                cmd = new SqlCommand("Select * from TimeTable where Course like '%BCA Ist Sem%'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L111.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5).ToString ().Replace (" ","<br/>") + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L112.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L113.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5).ToString().Replace(" ", "<br/>") + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L114.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5).ToString().Replace(" ", "<br/>") + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L115.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L116.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L121.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L122.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L123.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L124.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L125.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L126.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L131.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L132.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L133.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L134.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L135.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L136.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L141.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L142.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L143.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L144.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L145.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L146.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L151.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L152.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L153.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L154.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L155.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L156.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L161.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L162.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L163.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L164.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L165.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L166.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                }
                con.Close();
                cmd = new SqlCommand("Select * from TimeTable where Course like '%BCA IIIrd Sem%'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L311.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L312.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L313.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L314.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L315.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L316.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L321.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L322.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L323.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L324.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L325.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L326.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L331.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L332.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L333.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L334.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L335.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L336.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L341.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L342.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L343.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L344.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L345.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L346.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L351.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L352.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L353.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L354.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L355.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L356.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L361.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L362.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L363.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L364.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L365.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L366.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                }
                con.Close();
                cmd = new SqlCommand("Select * from TimeTable where Course like '%BCA Vth Sem%'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L511.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L512.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L513.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L514.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L515.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Mon" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L516.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L521.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L522.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L523.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L524.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L525.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Tue" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L526.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L531.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L532.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L533.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L534.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L535.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Wed" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L536.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L541.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L542.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L543.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L544.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L545.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Thurs" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L546.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L551.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L552.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L553.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L554.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L555.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Fri" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L556.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 1)
                    {
                        L561.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 2)
                    {
                        L562.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 3)
                    {
                        L563.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 4)
                    {
                        L564.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 5)
                    {
                        L565.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                    if (dr.GetValue(1).ToString() == "Sat" && Convert.ToInt32(dr.GetValue(2)) == 6)
                    {
                        L566.Text = dr.GetValue(3) + "<br/>" + dr.GetValue(5) + "(" + dr.GetValue(4) + ")";
                    }
                }
                con.Close();
            }
        }
    }
}