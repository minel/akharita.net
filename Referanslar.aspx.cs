using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Referanslar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int gid;

        if (Request.QueryString["galleryid"] != null)
        {
            gid = Convert.ToInt32(Request.QueryString["galleryid"]);
        }
    }
}