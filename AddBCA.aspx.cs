using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class AddBCA : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr = null;
    string course = null;
    public void getData(out string day, out int period, out string room, out string subject, out string teacher, out string sname, out int lec)
    {
        Random rd = new Random();
        day = null;
        room = null;
        subject = null;
        teacher = null;
        sname = null;
        lec = 0;
        //course = null;
        switch (rd.Next(1, 7))
        {
            case 1: day = "Mon"; break;
            case 2: day = "Tue"; break;
            case 3: day = "Wed"; break;
            case 4: day = "Thurs"; break;
            case 5: day = "Fri"; break;
            case 6: day = "Sat"; break;
        }
        //room = "LU -" + rd.Next(1, 4);
        period = rd.Next(1, 7);
    room:
        cmd = new SqlCommand("Select top 1 RoomNo from Room order by NEWID() ", con);
        // con.Open();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            dr.Read();
            room = dr["RoomNo"].ToString();
            con.Close();
        }
        if (room == "LAB")
            goto room;
        // Label2.Text = room;
        cmd = new SqlCommand("Select top 1 SName,SCode,Teacher,SLecWeek from Subject where Course like '%" + course  + "%' order by NEWID()", con);
        //con.Open();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        dr = cmd.ExecuteReader();
        if (dr.HasRows == true)
        {
            dr.Read();
            subject = dr["SCode"].ToString();
            teacher = dr["Teacher"].ToString();
            sname = dr["SName"].ToString();
            lec = Convert.ToInt32(dr["SLecWeek"]);
            //course = dr["Course"].ToString();
            con.Close();
        }


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cn"] == null)
        {
            Response.Write("<script>alert('some error occurred')</script>");
        }
        else
        {
            int ts,ts1=0;
            course = Session["cn"].ToString ();
            cmd = cmd = new SqlCommand("Select sum(SLecWeek) from Subject where Course like '%" + course + "%' ", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            ts = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new SqlCommand("Select count(TtId) from TimeTable where Course like '%" + course + "%' having count(Ttid)>=" + ts, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                con.Close();
                Response.Write("<script>alert('Time Table already generated ')</script>");
                return;
            }
            else
            {

                dr.Close();
                cmd = new SqlCommand("Select count(TtId) from TimeTable where Course like '%"+ course +"%' ", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                ts1 = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                //course = "BCA Ist SEM";
                //goto Beg;

            }
            //ts = s;
            con.Close();
            int i = ts1;
        start:
            try
            {
                if (i > (ts - 1))
                {
                    Response.Write("<script>alert('Time Table saved successfully')</script>");
                    return;
                }
                else
                {
                    string day = string.Empty;
                    string room = string.Empty;
                    string sub = string.Empty;
                    string teacher = string.Empty;
                    string sname = string.Empty;
                    int period = 0;
                    int lec = 0;
                    getData(out day, out period, out room, out sub, out teacher, out sname, out lec);
                    //if (room == "LAB")
                    //    getData(out day, out period, out room, out sub, out teacher, out sname);
                    //Check subject and course
                    cmd = new SqlCommand("Select count(Ttid) from TimeTable where Course='" + course + "' having count(Ttid)>=" + ts, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        //Response.Write("<script>alert('Time table has already been generated for this course. ')</script>");
                        //Panel1.Visible = true;
                        dr.Close();
                        con.Close();
                        return;
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                    }



                    //check for available period in the day

                    cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Course='" + course + "'", con);
                    //con.Open();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        con.Close();
                        goto start;
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                    }
                    if (sname != "LAB")
                    {


                        //check for subject of same course not more than one times in a day
                        cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Subject='" + sub + "' and Course='" + course + "'", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            con.Close();
                            goto start;
                        }
                        else
                        {
                            dr.Close();
                            con.Close();
                        }

                        //check for if a teacher is having more than two classes in a day
                        cmd = new SqlCommand("Select count(Ttid) from TimeTable where Day='" + day + "' and Teacher='" + teacher + "' and Course='" + course + "' having count(Ttid)>=2", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            con.Close();
                            goto start;
                        }
                        else
                        {
                            dr.Close();
                            con.Close();
                        }
                        //check for if a room is having  clashes
                        cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Room='" + room + "'", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            con.Close();
                            goto start;
                            // Response.Write("<script>alert('This Room is alredy used.. ')</script>");
                            // return;
                        }
                        else
                        {
                            dr.Close();
                            con.Close();
                        }

                        //check for if a teacher is having more than four classes for the course
                        cmd = new SqlCommand("Select Count(Ttid) from TimeTable where Teacher='" + teacher + "' and Course='" + course + "' having count(Ttid) >='" + lec + "'", con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            con.Close();
                            goto start;
                        }
                        else
                        {
                            dr.Close();
                            con.Close();
                        }

                        //check for if a teacher is having class clashes
                        cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Teacher = '" + teacher + "'", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            con.Close();
                            goto start;
                        }
                        else
                        {
                            dr.Close();
                            con.Close();
                        }
                        cmd = new SqlCommand("Insert Into TimeTable Values('" + day + "','" + period + "', '" + sub + "','" + room + "','" + teacher + "','" + course + "')", con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        int n = cmd.ExecuteNonQuery();
                        //if (n > 0)
                        //{
                        //    Label1.Text = "Suc";
                        //}
                        //else
                        //    Label1.Text = "Error";
                        con.Close();
                        i = i + 1;
                        goto start;
                    }
                    if (sname == "LAB")
                    {
                        cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Room='" + sname + "' ", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {

                            goto start;
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + (period + 1) + "' and Room='" + sname + "' ", con);
                            //con.Open();
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                             dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                goto start;
                            }
                            else
                            {
                                dr.Close();
                                cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + (period + 2) + "' and Room='" + sname + "' ", con);
                                //con.Open();
                                if (con.State == ConnectionState.Closed)
                                {
                                    con.Open();
                                }
                                dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                    goto start;
                                }
                            }
                        }
                        con.Close();


                        cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Subject='" + sub + "' ", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        //dr = cmd.ExecuteReader();
                        if (Convert.ToInt32(cmd.ExecuteScalar()) != 0)
                        {
                            goto start;
                        }
                        //cmd = new SqlCommand("Select Count(Ttid) from TimeTable where day='" + day + "' and Subject='" + sub + "' and Course='" + course + "' having Count(Ttid)>=2", con);
                        ////con.Open();
                        //if (con.State == ConnectionState.Closed)
                        //{
                        //    con.Open();
                        //}
                        ////dr = cmd.ExecuteReader();
                        //int b = Convert.ToInt32(cmd.ExecuteScalar());
                        //if (b >= 2)
                        //{
                        //    //Response.Write("LAB has been assigned six times for this course");
                        //    con.Close();
                        //    //return;
                        //    goto start;
                        //}

                        cmd = new SqlCommand("Select Count(Ttid) from TimeTable where Subject='" + sub + "' and Course='" + course + "' having Count(Ttid)>='" + lec + "'", con);
                        //con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        //dr = cmd.ExecuteReader();
                        int a = Convert.ToInt32(cmd.ExecuteScalar());
                        if (a >= lec)
                        {
                            //Response.Write("LAB has been assigned six times for this course");
                            con.Close();
                            //return;
                            goto start;
                        }
                        else
                        {

                            if (period != 6 && period != 5)
                            {
                                cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period=" + (period + 1) + " and Course='" + course + "'", con);
                                //con.Open();
                                if (con.State == ConnectionState.Closed)
                                {
                                    con.Open();
                                }
                                dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                    dr.Close();
                                    con.Close();
                                    goto start;
                                }
                                else
                                {
                                    dr.Close();
                                    cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period=" + (period + 2) + " and Course='" + course + "'", con);
                                    //con.Open();
                                    if (con.State == ConnectionState.Closed)
                                    {
                                        con.Open();
                                    }
                                    dr = cmd.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        dr.Close();
                                        con.Close();
                                        goto start;
                                    }
                                    else
                                    {
                                        dr.Close();
                                        cmd = new SqlCommand("insert into TimeTable values('" + day + "','" + period + "','" + sub + "','" + sname + "','" + teacher + "','" + course + "')", con);
                                        cmd.ExecuteNonQuery();
                                        cmd = new SqlCommand("insert into TimeTable values('" + day + "','" + (period + 1) + "','" + sub + "','" + sname + "','" + teacher + "','" + course + "')", con);
                                        cmd.ExecuteNonQuery();
                                        cmd = new SqlCommand("insert into TimeTable values('" + day + "','" + (period + 2) + "','" + sub + "','" + sname + "','" + teacher + "','" + course + "')", con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        i = i + 3;
                                        //Response.Write("<script>alert('Saved successfully')</script>");
                                        goto start;

                                    }
                                }

                            }
                            
                            else
                            {
                                goto start;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

    }
}