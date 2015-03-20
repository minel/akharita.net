<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Referanslar.aspx.cs" Inherits="Referanslar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CphMidContents" runat="Server">

    <div class="pages-head">
        <h1>Referanslarımız</h1>
        <h3>Bugüne kadar yapmış olduğumuz çalışmaları bu başlık altında görebilirsiniz.</h3>

    </div>

    <div class="referanslar-contains" runat="server">
        <div class="accordionmenu referanslar-menu" runat="server">
            <asp:Literal ID="ltrphotogroup" runat="server">

            </asp:Literal>
        </div>
        <div class="vr"></div>
        <div class="referanslar-gallery" runat="server" id="gallerydiv">
            <!-- this are is photo gallery area. This area will bind animated photos jquery ajax post/get method thats all -->
            
        </div>
    </div>




</asp:Content>

