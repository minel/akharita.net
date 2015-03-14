using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StringOperations
/// </summary>
public static class StringOperations
{
    public static string EnglishCharLCase(this string s)
    {
        string rzlt = string.Empty;
        if (!String.IsNullOrEmpty(s))
        {
            rzlt = s;
            rzlt = rzlt
                   .Replace("Ü", "u")
                   .Replace("Ğ", "g")
                   .Replace("Ş", "s")
                   .Replace("Ç", "c")
                   .Replace("Ö", "o")
                   .Replace("İ", "i")
                   .Replace("I", "i")
                   .Replace("ü", "u")
                   .Replace("ğ", "g")
                   .Replace("ş", "s")
                   .Replace("ç", "c")
                   .Replace("ö", "o")
                   .Replace("ı", "i");
            rzlt = rzlt.ToLower();
        }
        return rzlt;
    }


    public static List<string> GetPhotoNames(this string path)
    {
        string galleryfoldername = Directory.GetDirectories(path).FirstOrDefault().Split('\\')[10]; // servera atarken 8 yapacaksın galiba

        string subpath = path + "\\" + galleryfoldername;

        string[] photopaths = Directory.GetFiles(subpath);

        List<string> photonames = new List<string>();

        foreach (var item in photopaths)
        {
            photonames.Add(item.Split('\\')[11]); // o zaman burada server da 9 mu oluyor şimdi
        }

        return photonames;

    }
    
}