using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class UpdateTimeTable : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr = null;
    string all,lscode,lteacher,lroom,lp,ld;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["uname"]==null)
            Response.Redirect("Login.aspx");
    
        this.L11.Click += new System.EventHandler(this.btn_Click); this.L12.Click += new System.EventHandler(this.btn_Click); this.L13.Click += new System.EventHandler(this.btn_Click);
        this.L14.Click += new System.EventHandler(this.btn_Click); this.L15.Click += new System.EventHandler(this.btn_Click); this.L16.Click += new System.EventHandler(this.btn_Click);
        this.L21.Click += new System.EventHandler(this.btn_Click); this.L22.Click += new System.EventHandler(this.btn_Click); this.L23.Click += new System.EventHandler(this.btn_Click);
        this.L24.Click += new System.EventHandler(this.btn_Click); this.L25.Click += new System.EventHandler(this.btn_Click); this.L26.Click += new System.EventHandler(this.btn_Click);
        this.L31.Click += new System.EventHandler(this.btn_Click); this.L32.Click += new System.EventHandler(this.btn_Click); this.L33.Click += new System.EventHandler(this.btn_Click);
        this.L34.Click += new System.EventHandler(this.btn_Click); this.L35.Click += new System.EventHandler(this.btn_Click); this.L36.Click += new System.EventHandler(this.btn_Click);
        this.L41.Click += new System.EventHandler(this.btn_Click); this.L42.Click += new System.EventHandler(this.btn_Click); this.L43.Click += new System.EventHandler(this.btn_Click);
        this.L44.Click += new System.EventHandler(this.btn_Click); this.L45.Click += new System.EventHandler(this.btn_Click); this.L46.Click += new System.EventHandler(this.btn_Click);
        this.L51.Click += new System.EventHandler(this.btn_Click); this.L52.Click += new System.EventHandler(this.btn_Click); this.L53.Click += new System.EventHandler(this.btn_Click);
        this.L54.Click += new System.EventHandler(this.btn_Click); this.L55.Click += new System.EventHandler(this.btn_Click); this.L56.Click += new System.EventHandler(this.btn_Click);
        this.L61.Click += new System.EventHandler(this.btn_Click); this.L62.Click += new System.EventHandler(this.btn_Click); this.L63.Click += new System.EventHandler(this.btn_Click);
        this.L64.Click += new System.EventHandler(this.btn_Click); this.L65.Click += new System.EventHandler(this.btn_Click); this.L66.Click += new System.EventHandler(this.btn_Click);
       
        
    }
    private void cleartable()
    {
        //foreach (LinkButton L in form1.Controls.OfType<LinkButton>())
        //{
        //    L.Text = ""; 
        //}
        L11.Text = L12.Text = L13.Text = L14.Text = L15.Text = L16.Text = "";
        L21.Text = L22.Text = L23.Text = L24.Text = L25.Text = L26.Text = "";
        L31.Text = L32.Text = L33.Text = L34.Text = L35.Text = L36.Text = "";
        L41.Text = L42.Text = L43.Text = L44.Text = L45.Text = L46.Text = "";
        L51.Text = L52.Text = L53.Text = L54.Text = L55.Text = L56.Text = "";
        L61.Text = L62.Text = L63.Text = L64.Text = L65.Text = L66.Text = "";
    }
    protected void BtnView_Click(object sender, EventArgs e)
    {
        //cleartable();
        viewTimeTable(); 
       
    }
    private void viewTimeTable()
    { 
        
        string course = DrpCourse.SelectedValue;
        if (course.CompareTo("- Select Course -") != 0)
        {
            Panel1.Visible = true;
            cleartable();
            cmd = new SqlCommand("Select * from TimeTable where Course like '%" + course + "%'", con);
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
    //protected void L11_Click(object sender, EventArgs e)
    //{
    //    Response.Write("<script>alert('Time table has already been generated for this course. ')</script>");
    //}
    protected void BindDrpRoom()
    {
        con.Open();
        cmd = new SqlCommand("SELECT DISTINCT [RoomNo] FROM Room", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        da.Fill(ds);
        con.Close();
        DrpRoom .DataSource = ds;
        DrpRoom.DataTextField = "RoomNo";
        DrpRoom.DataBind();
        //DrpCatg.Items.Insert(0, new ListItem("- Select Service Category -", "0"));
    }
        
    protected void btn_Click(object sender, EventArgs e)
    {
        DrpPeriod.Visible = false;
        DrpRoom.Visible = false;
        TxtPeriod.Visible = true;
        TxtRoom.Visible = true;
        LinkButton btn = (LinkButton)sender;
        string id=(string )btn.ID ;
        if (id.Equals("L11")) { TxtPeriod.Text = "1"; DrpDay.Text = "Mon"; }
        if (id.Equals("L12")) { TxtPeriod.Text = "2"; DrpDay.Text = "Mon"; }
        if (id.Equals("L13")) { TxtPeriod.Text = "3"; DrpDay.Text = "Mon"; }
        if (id.Equals("L14")) { TxtPeriod.Text = "4"; DrpDay.Text = "Mon"; }
        if (id.Equals("L15")) { TxtPeriod.Text = "5"; DrpDay.Text = "Mon"; }
        if (id.Equals("L16")) { TxtPeriod.Text = "6"; DrpDay.Text = "Mon"; }
        if (id.Equals("L21")) { TxtPeriod.Text = "1"; DrpDay.Text = "Tue"; }
        if (id.Equals("L22")) { TxtPeriod.Text = "2"; DrpDay.Text = "Tue"; }
        if (id.Equals("L23")) { TxtPeriod.Text = "3"; DrpDay.Text = "Tue"; }
        if (id.Equals("L24")) { TxtPeriod.Text = "4"; DrpDay.Text = "Tue"; }
        if (id.Equals("L25")) { TxtPeriod.Text = "5"; DrpDay.Text = "Tue"; }
        if (id.Equals("L26")) { TxtPeriod.Text = "6"; DrpDay.Text = "Tue"; }
        if (id.Equals("L31")) { TxtPeriod.Text = "1"; DrpDay.Text = "Wed"; }
        if (id.Equals("L32")) { TxtPeriod.Text = "2"; DrpDay.Text = "Wed"; }
        if (id.Equals("L33")) { TxtPeriod.Text = "3"; DrpDay.Text = "Wed"; }
        if (id.Equals("L34")) { TxtPeriod.Text = "4"; DrpDay.Text = "Wed"; }
        if (id.Equals("L35")) { TxtPeriod.Text = "5"; DrpDay.Text = "Wed"; }
        if (id.Equals("L36")) { TxtPeriod.Text = "6"; DrpDay.Text = "Wed"; }
        if (id.Equals("L41")) { TxtPeriod.Text = "1"; DrpDay.Text = "Thurs"; }
        if (id.Equals("L42")) { TxtPeriod.Text = "2"; DrpDay.Text = "Thurs"; }
        if (id.Equals("L43")) { TxtPeriod.Text = "3"; DrpDay.Text = "Thurs"; }
        if (id.Equals("L44")) { TxtPeriod.Text = "4"; DrpDay.Text = "Thurs"; }
        if (id.Equals("L45")) { TxtPeriod.Text = "5"; DrpDay.Text = "Thurs"; }
        if (id.Equals("L46")) { TxtPeriod.Text = "6"; DrpDay.Text = "Thurs"; }
        if (id.Equals("L51")) { TxtPeriod.Text = "1"; DrpDay.Text = "Fri"; }
        if (id.Equals("L52")) { TxtPeriod.Text = "2"; DrpDay.Text = "Fri"; }
        if (id.Equals("L53")) { TxtPeriod.Text = "3"; DrpDay.Text = "Fri"; }
        if (id.Equals("L54")) { TxtPeriod.Text = "4"; DrpDay.Text = "Fri"; }
        if (id.Equals("L55")) { TxtPeriod.Text = "5"; DrpDay.Text = "Fri"; }
        if (id.Equals("L56")) { TxtPeriod.Text = "6"; DrpDay.Text = "Fri"; }
        if (id.Equals("L61")) { TxtPeriod.Text = "1"; DrpDay.Text = "Sat"; }
        if (id.Equals("L62")) { TxtPeriod.Text = "2"; DrpDay.Text = "Sat"; }
        if (id.Equals("L63")) { TxtPeriod.Text = "3"; DrpDay.Text = "Sat"; }
        if (id.Equals("L64")) { TxtPeriod.Text = "4"; DrpDay.Text = "Sat"; }
        if (id.Equals("L65")) { TxtPeriod.Text = "5"; DrpDay.Text = "Sat"; }
        if (id.Equals("L66")) { TxtPeriod.Text = "6"; DrpDay.Text = "Sat"; } 
        all = btn.Text;
        all = all.Replace("<br/>", string.Empty);
        lscode =all.Substring(0, 8);
        Session["b1"] = lscode;
        LblSCode.Text =lscode  ;
        int start = all.IndexOf("(") + 1;
        int m = start - 9;
        int end = all.IndexOf(")", start);
        lteacher = all.Substring(8, m);
        lroom = all.Substring(start, end-start );
        LblTeacher.Text = lteacher ;
        TxtRoom .Text  = lroom ;
       BindDrpRoom();
       ld = DrpDay.Text;
       lp = TxtPeriod.Text;
       Session["b2"] = lteacher;
       Session["b3"] = lp;
       Session["b4"] = ld;
       Session["b5"] = lroom;
       DrpPeriod.Visible = false;
       DrpRoom.Visible = false;
       ModalPopupExtender1.Show();
       
    }
    protected string findSName(string sc)
    {
        string sn = string.Empty;
        cmd = new SqlCommand("Select SName from Subject where SCode='" + sc + "' ", con);
        //con.Open();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            sn = dr["SName"].ToString ();
        }
        con.Close();
        return sn;
    }
    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        //Label1.Text = Session["b1"].ToString ();
        
        string day = DrpDay .Text;
        int period = Convert.ToInt32(DrpPeriod.Text);
        string course = DrpCourse.SelectedValue;
        string sub = LblSCode.Text;
        string teacher = LblTeacher.Text;
        string room = DrpRoom.SelectedValue;
        string sn=findSName (sub);
    ////start:
        try
        {
            if (sn != "LAB")
            {
               
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

                    Response.Write("<script>alert('Second Class for this subject can not be scheduled on the same day. ')</script>");
                    //return;
                    goto end;
                }
                else
                {
                    dr.Close();
                    con.Close();
                }

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
                    //
                    Response.Write("<script>alert('Another Class exits.Please Select Carefully. ')</script>");
                    ModalPopupExtender1.Show();
                    //return;
                    goto end;
                }
                else
                {
                    dr.Close();
                    con.Close();
                }


                //check for if a teacher is having more than two classes in a day
                cmd = new SqlCommand("Select count(Ttid) from TimeTable where Day='" + day + "' and Teacher='" + teacher + "' having count(Ttid)>=2", con);
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
                    //
                    Response.Write("<script>alert('Sorry, the teacher has already two classes that day. ')</script>");
                    ModalPopupExtender1.Show();
                    //return;
                    goto end;
                }
                else
                {
                    dr.Close();
                    con.Close();
                }

                //        //check for if a teacher is having more than four classes for the course
                //        cmd = new SqlCommand("Select Count(Ttid) from TimeTable where Teacher='" + teacher + "' and Course='" + course + "' having count(Ttid) >=4", con);
                //        if (con.State == ConnectionState.Closed)
                //        {
                //            con.Open();
                //        }
                //        dr = cmd.ExecuteReader();
                //        if (dr.Read())
                //        {
                //            dr.Close();
                //            con.Close();
                //            //goto end;
                //            Response.Write("<script>alert('This Subject has already four classes scheduled. ')</script>");
                //            return;
                //        }
                //        else
                //        {
                //            dr.Close();
                //            con.Close();
                //        }

                //check for if a teacher is having class clashes
                //cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Teacher='" + teacher + "'", con);
                ////con.Open();
                //if (con.State == ConnectionState.Closed)
                //{
                //    con.Open();
                //}
                //dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    dr.Close();
                //    con.Close();
                //    // 
                //    Response.Write("<script>alert('Teacher's Class is clashing... ')</script>");
                //    ModalPopupExtender1.Show();
                //    //return;
                //    goto end;
                //}
                //else
                //{
                //    dr.Close();
                //    con.Close();
                //}
                //check for if a room is having  clashes
                //cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Room='" + room + "'", con);
                ////con.Open();
                //if (con.State == ConnectionState.Closed)
                //{
                //    con.Open();
                //}
                //dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    dr.Close();
                //    con.Close();
                //    // 
                //    Response.Write("<script>alert('This Room is alredy used.. ')</script>");
                //    ModalPopupExtender1.Show();
                //    //return;
                //    goto end;
                //}
                //else
                //{
                //    dr.Close();
                //    con.Close();
                //}
                cmd = new SqlCommand("Insert Into TimeTable Values('" + day + "','" + period + "', '" + sub + "','" + room + "','" + teacher + "','" + course + "')", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int n = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete from TimeTable  Where Course like '%" + DrpCourse.SelectedValue + "%' and Day='" + Session["b4"] + "' and Period='" + Session["b3"] + "' and Subject='" + Session["b1"] + "' and Room='" + Session["b5"] + "' and Teacher='" + Session["b2"] + "'  ", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (sn == "LAB")
            {
                
                
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
                    //
                    Response.Write("<script>alert('Another Class exits.Please Select Carefully. ')</script>");
                    ModalPopupExtender1.Show();
                    //return;
                    goto end;
                }
                else
                {
                    dr.Close();
                    con.Close();
                }
                cmd = new SqlCommand("Select Ttid from TimeTable where Day='" + day + "' and Period='" + period + "' and Teacher='" + teacher + "'", con);
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
                    // 
                    Response.Write("<script>alert('Teacher's Class is clashing... ')</script>");
                    ModalPopupExtender1.Show();
                    //return;
                    goto end;
                }
                else
                {
                    dr.Close();
                    con.Close();
                }
                if (period != 6)
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
                        Response.Write("<script>alert('Two consecutive periods are not available ')</script>");
                        ModalPopupExtender1.Show();
                        goto end;
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into TimeTable values('" + day + "','" + period + "','" + sub + "','" + room  + "','" + teacher + "','" + course + "')", con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into TimeTable values('" + day + "','" + (period + 1) + "','" + sub + "','" + room + "','" + teacher + "','" + course + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd = new SqlCommand("Delete from TimeTable  Where Course like '%" + DrpCourse.SelectedValue + "%' and Day='" + Session["b4"] + "' and Period='" + Session["b3"] + "' and Subject='" + Session["b1"] + "' and Room='" + Session["b5"] + "' and Teacher='" + Session["b2"] + "'  ", con);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int p = Convert.ToInt32(Session["b3"]);
                        p = p + 1;
                        con.Open();
                        cmd = new SqlCommand("Delete from TimeTable  Where Course like '%" + DrpCourse.SelectedValue + "%' and Day='" + Session["b4"] + "' and Period='" + p + "' and Subject='" + Session["b1"] + "' and Room='" + Session["b5"] + "' and Teacher='" + Session["b2"] + "'  ", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //Response.Write("<script>alert('Saved successfully')</script>");
                        //goto start;

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
        viewTimeTable();
        DrpPeriod.Visible = false;
        DrpRoom.Visible = false;
        TxtPeriod.Visible = true;
        TxtRoom.Visible = true;
    end:
        return;
    }
    protected void DrpDay_SelectedIndexChanged(object sender, EventArgs e)
    { int[] period={1,2,3,4,5,6};

            TxtPeriod.Visible = false;
            DrpPeriod.Visible = true;
            DrpPeriod.Items .Clear ();

            cmd = new SqlCommand("Select period from timetable where day=@day and course=@course union select period from timetable where day=@day and teacher=@teacher ", con);
        cmd.Parameters.AddWithValue("@day",DrpDay.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@course",DrpCourse.SelectedItem.Text);
           cmd.Parameters.AddWithValue("@teacher",LblTeacher.Text);
            con.Open();

        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            period[Convert.ToInt32(dr["Period"].ToString())-1] = 0;
        
        }
        DrpPeriod.Items.Insert(0, new ListItem("- Select Period -", "0"));
        for (int i = 0; i < 6; i++)
        {
            if (period[i] != 0)
                DrpPeriod.Items.Add(period[i].ToString());
        }
        if (DrpPeriod.Items.Count == 1)
            DrpPeriod.Items .Add  ("No Periods available");



        ModalPopupExtender1.Show();

        con.Close();
        
        
    }
    //protected void DrpPeriod_SelectedIndexChanged(object sender, EventArgs e)
    //{
        
    //}
    protected void DrpPeriod_SelectedIndexChanged(object sender, EventArgs e)
    {
        string[] room = { "LU-3", "LU-4", "L-4", "SCR","LAB" };

        TxtRoom.Visible = false;
        DrpRoom.Visible = true;
        DrpRoom.Items.Clear();

        cmd = new SqlCommand("Select Room from timetable where day=@day and period=@period ", con);
        cmd.Parameters.AddWithValue("@day", DrpDay.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@period", DrpPeriod.SelectedItem.Text);
        // cmd.Parameters.AddWithValue("@teacher",LblTeacher.Text);
        con.Open();

        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            //room[Convert.ToInt32(dr["Period"].ToString()) - 1] = 0;
            for (int i = 0; i < 5; i++)
            {
                if (room[i] == dr["Room"].ToString())
                    room[i] = "0";
            }

        }
        DrpRoom.Items.Insert(0, new ListItem("- Select Room -", "0"));
        for (int i = 0; i < 5; i++)
        {
            if (room[i] != "0")
                DrpRoom.Items.Add(room[i].ToString());
        }
        if (DrpRoom.Items.Count == 1)
            DrpRoom.Items.Add("No rooms available");

        ModalPopupExtender1.Show();

        con.Close();
        
    }
}