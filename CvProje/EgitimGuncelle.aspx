<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EgitimGuncelle.aspx.cs" Inherits="CvProje.EgitimGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h4>Eğitim Güncelleme Sayfası</h4>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Metni Güncellemek İçin Yazınız"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Güncellenen metni yazınız" CssClass="form-control"></asp:TextBox>
    
    <br />
    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-group" OnClick="Button1_Click" />

</asp:Content>
