﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblKetQua.Text = "Username: " + Request.Form.Get("txtUserName")
+ "<br>Password: " + Request.Form.Get("txtPassword");
        }
    }
    
}