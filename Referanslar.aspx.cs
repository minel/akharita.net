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
    StringBuilder sbphotos = new StringBuilder();

    List<string> fnames = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {

        string alphabet = Server.MapPath("~/images/References");

        List<string> folders = Directory.GetDirectories(alphabet).ToList();

        foreach (var item in folders)
        {
            fnames.Add(item.Split('\\')[9]); //server için 7 olacak local 9
        }


        WriteMenu(fnames);

        string letterpath = Server.MapPath("~/images/References/A");

        List<string> defaultImages = StringOperations.GetPhotoNames(letterpath);

        FillData(defaultImages);

    }

    private void FillData(List<string> defaultImages)
    {
        
    }

    private void WriteMenu(List<string> lettergroup)
    {
        sb.Append("<ul id='photomenu'>");

        for (int i = 0; i < lettergroup.Count; i++)
        {
            sb.Append("<li class='has-sub'><a href='/referanslar/" + lettergroup[i] + "'>" + lettergroup[i] + "</a>");

            sb.Append("<ul>");
            string underletter = Server.MapPath("~/images/References/" + lettergroup[i]);

            List<string> foldersbyletter = Directory.GetDirectories(underletter).ToList();

            List<string> fnames2 = new List<string>();

            string subfoldername;

            foreach (var item in foldersbyletter)
            {
                subfoldername = item.Split('\\')[10]; //server tarafında 8 localde 10

                //sb.Append("<li><a class='photoslink' data-id='/referanslar/" + lettergroup[i].Trim() + "/" + subfoldername.Replace(' ', '-') + "'>" + subfoldername + "</a></li>");
                sb.Append("<li><a class='photoslink' data-id='" + subfoldername.Replace(' ', '-').EnglishCharLCase()  + "'>" + subfoldername + "</a></li>");

            }

            

            sb.Append("</ul></li>");

        }

        sb.Append("</ul>");

        ltrphotogroup.Text = sb.ToString();

    }

    /*private void FirstLoad()
    {
        string path = Server.MapPath("~/images/References/A");

        string galleryfoldername = Directory.GetDirectories(path).FirstOrDefault().Split('\\')[10]; // servera atarken 8 yapacaksın galiba

        string subpath = path + "\\" + galleryfoldername;

        string[] photopaths = Directory.GetFiles(subpath);


        List<string> photonames = new List<string>();

        foreach (var item in photopaths)
        {
            photonames.Add(item.Split('\\')[11]); // o zaman burada server da 9 mu oluyor şimdi
        }


    }*/
    

}