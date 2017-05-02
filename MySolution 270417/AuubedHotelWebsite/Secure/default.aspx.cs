using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure_default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear lblUserInfo
        lblUserInfo.Text = "";
        //clear lblError
        lblError.Text = "";
        //display the username
        lblUserInfo.Text = "The current user is " + User.Identity.Name;
        //test to see if they are an admin
        if (User.IsInRole("admin") == true)
        {
            //display confirmation
            lblUserInfo.Text = lblUserInfo.Text + ". You are an admin.";
        }
        else
        {
            lblUserInfo.Text = lblUserInfo.Text + ". You are <strong> not </strong> an admin";
        }
    }
}