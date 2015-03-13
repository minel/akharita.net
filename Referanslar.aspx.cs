using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Referanslar : System.Web.UI.Page
{
    StringBuilder sb = new StringBuilder();

    List<string> fnames = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {

        string alphabet = Server.MapPath("~/images/References");

        List<string> folders = Directory.GetDirectories(alphabet).ToList();

        foreach (var item in folders)
        {
            fnames.Add(item.Split('\\')[9]); //server için 7 olacak
        }


        WriteMenu(fnames);

    }

    private void WriteMenu(List<string> lettergroup)
    {
        sb.Append("<ul id='photomenu'>");

        for (int i = 0; i < lettergroup.Count; i++)
        {
            sb.Append("<li class='has-sub'><a href='/referanslar/"+lettergroup[i]+"'>" + lettergroup[i] + "</a>");
            
            sb.Append("<ul>");
            string underletter  = Server.MapPath("~/images/References/"+ lettergroup[i]);

            List<string> foldersbyletter = Directory.GetDirectories(underletter).ToList();

            List<string> fnames2 = new List<string>();

            string subfoldername;

            foreach (var item in foldersbyletter)
            {
                subfoldername = item.Split('\\')[10]; //server tarafında iki eksik

                sb.Append("<li><a href='/referanslar/"+lettergroup[i].Trim()+"/"+subfoldername.Replace(' ','-')+"'>"+subfoldername+"</a></li>");
            }

            
            sb.Append("</ul></li>");

        }

        sb.Append("</ul>");

        ltrphotogroup.Text = sb.ToString();

    }

}