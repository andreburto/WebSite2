using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPoster;

public partial class Write : System.Web.UI.Page
{
    private string msg = "Ready";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (msg.Length > 0)
        {
            Label1.Text = msg;
        }
    }
    protected void btnPost_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        Posting p = new Posting(conn);

        try
        {
            p.NewPost(txtTitle.Text, txtPost.Text);
            msg = "Message posted.";
            txtPost.Text = "";
            txtTitle.Text = "";
        }
        catch(Exception ex)
        {
            throw new Exception("Error", ex);
        }

        Label1.Text = msg;
    }
}