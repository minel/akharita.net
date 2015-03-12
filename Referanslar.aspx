<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Referanslar.aspx.cs" Inherits="Referanslar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CphMidContents" Runat="Server">

    <div class="pages-head">
        <h1>Referanslarımız</h1>
        <h3>
        Bugüne kadar yapmış olduğumuz çalışmaları bu başlık altında görebilirsiniz.</h3>
    </div>

    <div class="referanslar-contains">
        <div class="referanslar-menu">
           <!-- i will add ul-li menu and it's binding asp.net repeater -->
        </div>
        <div class="referanslar-gallery">
            <!-- this are is photo gallery area. This area will bind animated photos jquery ajax post/get method thats all -->
        </div>
    </div>

    <script type="text/javascript">
        //this is jquery ajax post area
    </script>


</asp:Content>

