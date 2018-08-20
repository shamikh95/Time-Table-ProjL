using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Timetab.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    SqlDataReader dr = null;
    string course = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
}