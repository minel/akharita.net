<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Referanslar.aspx.cs" Inherits="Referanslar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CphMidContents" Runat="Server">

    <div class="pages-head">
        <h1>Referanslarımız</h1>
        <h3>
        Bugüne kadar yapmış olduğumuz çalışmaları bu başlık altında görebilirsiniz.</h3>
        
    </div>

    <div class="referanslar-contains">
        <div class="accordionmenu referanslar-menu">
            <asp:Literal ID="ltrphotogroup" runat="server">

            </asp:Literal>
        </div>
        <div class="vr"></div>
        <div class="referanslar-gallery" runat="server" id="gallerydiv">
            <!-- this are is photo gallery area. This area will bind animated photos jquery ajax post/get method thats all -->
            <a class="fancybox" rel="gallery1" href="/images/References/A/Antalya/KAO AKM.jpg" title="deneme">
                <img src="images/References/A/Antalya/KAO%20AKM.jpg" />
            </a>
            <a class="fancybox" rel="gallery1" href="/images/References/A/Antalya/KAO AKM2.jpg" title="deneme">
                <img src="images/References/A/Antalya/KAO%20AKM2.jpg" />
            </a>
        </div>
    </div>

    


</asp:Content>

