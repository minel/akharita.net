<%@ Application Language="C#" %>

<script runat="server">

    void Application_BeginRequest(object sender, EventArgs e)
    {
        HttpContext MyContext = HttpContext.Current;
        string q = Request.RawUrl.ToLower(); if (q.StartsWith("/")) q = q.Remove(0, 1);

        MatchCollection mc = null;
        string[] param = null;

        mc = Regex.Matches(q, @"hizmetler$");
        param = q.Split('/');
        if (mc.Count > 0)
            MyContext.RewritePath("/Hizmetler.aspx");

        mc = Regex.Matches(q, @"hakkimizda$");
        param = q.Split('/');
        if (mc.Count > 0)
            MyContext.RewritePath("/Hakkimizda.aspx");

        mc = Regex.Matches(q, @"referanslar$");
        param = q.Split('/');
        if (mc.Count > 0)
            MyContext.RewritePath("/Referanslar.aspx");

        mc = Regex.Matches(q, @"iletisim$");
        param = q.Split('/');
        if (mc.Count > 0)
            MyContext.RewritePath("/Iletisim.aspx");
        
    }
       
</script>
