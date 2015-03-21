<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Cepheform.aspx.cs" Inherits="Cepheform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CphMidContents" runat="Server">
    <div class="pages-head">
        <h1>Teklif Talebi Oluşturun</h1>
        <h3>Size en uygun fiyat teklifi için formumuzu doldurabilirsiniz.</h3>
    </div>

    <form id="frmCepheTeklif" runat="server">
        <div class="teklifForm">
            <div class="fStr">
                <div class="fHucre">Şirket Adı - Yetkili Kişi *</div>
                <div class="fHucre">
                    <asp:TextBox ID="tbAd" CssClass="tb" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="tbAd" ValidationGroup="1"
                        Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Adınızı girmediniz."></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="fStr">
                <div class="fHucre">Şirket Telefonu *</div>
                <div class="fHucre">
                    <asp:TextBox ID="tbTelefon" CssClass="tb" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="tbTelefon" ValidationGroup="1"
                        Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Telefonunuzu girmediniz."></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="fStr">
                <div class="fHucre">E - Posta</div>
                <div class="fHucre">
                    <asp:TextBox ID="tbEposta" CssClass="tb" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="fStr">
                <div class="fHucre">Yaklaşık Uygulama Alanı (m2) *</div>
                <div class="fHucre">
                    <asp:TextBox ID="tbMkare" CssClass="tb" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="tbMkare" ValidationGroup="1"
                        Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Uygulama alanını girmediniz."></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="fStr">
                <div class="fHucre">Yapının Cinsi</div>
                <div class="fHucre">
                    <asp:CheckBoxList runat="server">
                        <asp:ListItem>Betonarme</asp:ListItem>
                        <asp:ListItem>Çelik</asp:ListItem>
                        <asp:ListItem>Diğer</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
        </div>
    </form>


</asp:Content>

