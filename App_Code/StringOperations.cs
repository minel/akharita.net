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
        string[] photopaths = Directory.GetFiles(path);

        List<string> photonames = new List<string>();

        foreach (var item in photopaths)
        {
            string[] words = item.Split('\\');

            string galleryfoldername = words[words.Count() - 2];
            string photoname = words[words.Count() - 1];

            photonames.Add(galleryfoldername + "/" + photoname);
        }

        return photonames;

    }

    public static string ReplaceUniCodeChar(this string s)
    {
        string result = string.Empty;
        if (!String.IsNullOrEmpty(s))
        {
            result = s;

            result = result
                        .Replace("+", " ")
                        .Replace("%2f", "/")
                        .Replace("%u00e7", "ç")
                        .Replace("%u011f", "ğ")
                        .Replace("%u0131", "ı")
                        .Replace("%u00f6", "ö")
                        .Replace("%u015f", "ş")
                        .Replace("%u00fc", "ü")
                        .Replace("%u00c7", "Ç")
                        .Replace("%u011e", "Ğ")
                        .Replace("%u0130", "İ")
                        .Replace("%u00d6", "Ö")
                        .Replace("%u015e", "Ş")
                        .Replace("%u00dc", "Ü");
        }

        return result;
    }

}