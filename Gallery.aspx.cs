using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gallery : System.Web.UI.Page
{
    StringBuilder sbphotos = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {
        string galleryname = Request.Form.ToString();
        string cleargname = galleryname.ReplaceUniCodeChar();
        string letter = cleargname.Split('/')[0];
        string photosin = Server.MapPath("~/images/References/"+cleargname.Replace('/', '\\'));

        List<string> images = StringOperations.GetPhotoNames(photosin);

        FillData(images, letter);

    }

    private void FillData(List<string> images, string letter)
    {
        foreach (var item in images)
        {
            sbphotos.Append("" +
            "<a class='fancybox' rel='gallery1' href='/images/References/"+letter+"/" + item + "' title='"+item.Replace(".jpg","")+"'>" +
                "<img src='/images/References/"+letter+"/" + item + "' />" +
            "</a>" +
            "");
        }

        gallery.InnerHtml = sbphotos.ToString();

    }
}