<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvProje.YetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <h4>Yetenek Güncelleme Sayfası</h4>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Yetenek Güncelleme"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Güncellenmiş metni yazınız" ></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-group" OnClick="Button1_Click"/>

</asp:Content>
