﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace RentACar.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(UserName.Text, UserPass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, chkboxPersist.Checked);
            }
            else
            {
                Msg.Text = "Invalid User Name and/or Password";
            }
        }
    }
}