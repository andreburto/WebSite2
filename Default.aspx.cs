using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPoster;

public partial class _Default : System.Web.UI.Page
{
    //private string conn;
    private Posting p;
    private List<Post> posts;

    protected void Page_Load(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        p = new Posting(conn);
        int pcount = p.CountPosts();
        posts = p.GetPosts();

        Repeater1.DataSource = posts;
        Repeater1.DataBind();

        lblPCount.Text = pcount.ToString();
    }
}