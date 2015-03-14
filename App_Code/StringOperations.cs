using System;
using System.Collections.Generic;
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
}