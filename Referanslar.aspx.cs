using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Referanslar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string a = Server.MapPath("~/images/References");

        List<string> folders = Directory.GetDirectories(a).ToList();

        List<string> fnames = new List<string>();

        foreach (var item in folders)
        {
            fnames.Add(item.Split('\\')[9]); //server için 7 olacak
        }

        rptmenu.DataSource = fnames;
        rptmenu.DataBind();

    }
}