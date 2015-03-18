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
    StringBuilder sbdefphotos = new StringBuilder();

    List<string> fnames = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {

        string alphabet = Server.MapPath("~/images/References");

        List<string> folders = Directory.GetDirectories(alphabet).ToList();

        foreach (var item in folders)
        {
            string[] words = item.Split('\\');

            fnames.Add(words[words.Count() - 1]); //server için 7 olacak local 9 item.Count() - 1
        }


        WriteMenu(fnames);

        string letterpath = Server.MapPath("~/images/References/A");
        string firstfolderpath = Directory.GetDirectories(letterpath).FirstOrDefault();

        List<string> defaultImages = StringOperations.GetPhotoNames(firstfolderpath);

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
            string letter;

            foreach (var item in foldersbyletter)
            {
                string[] words = item.Split('\\');

                letter = words[words.Count() - 2];
                subfoldername = words[words.Count() - 1]; //server tarafında 8 localde 10

                //sb.Append("<li><a class='photoslink' data-id='/referanslar/" + lettergroup[i].Trim() + "/" + subfoldername.Replace(' ', '-') + "'>" + subfoldername + "</a></li>");
                sb.Append("<li><a class='photoslink' data-id='" + letter + "\\" + subfoldername.Replace(' ', '-').EnglishCharLCase() + "'>" + subfoldername + "</a></li>");

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