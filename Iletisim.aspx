<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CphMidContents" Runat="Server">
    <div class="pages-head">
        <h1>İletişim Bilgilerimiz</h1>
        <h3>
        Bize ulaşabileceğiniz adres ve telefon ve diğer iletişim bilgilerimiz</h3>
    </div>

    <div class="iletisim-contains">
        <div class="iletisim-item">
            <h2>Adresimiz</h2>
            <span>Özyurtlar N Towers B4 Blok  Haramidere - Esenyurt / İSTANBUL</span>
        </div>
        <div class="iletisim-item">
            <h2>Telefonlarımız</h2>
            <span><b>Tel1:</b> +90 (532) 588 07 90 &nbsp;&nbsp; <b>Tel2:</b> +90 (542) 319 03 91</span>
        </div>
        <div class="iletisim-item">
            <h2>Mail</h2>
            <span>info@akharita.com</span>
        </div>
        <div class="iletisim-map">
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6019.815795551649!2d28.703339937654935!3d41.02727091050417!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caa0c94fb38085%3A0x30b0b20265c987e0!2s%C3%96zyurtlar+Ntowers!5e0!3m2!1str!2s!4v1426155340037" width="890" height="400" frameborder="0" style="border:0"></iframe>
        </div>
    </div>

</asp:Content>

