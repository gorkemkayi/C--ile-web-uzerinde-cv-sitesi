﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvProje.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left:20px; margin-right:20px;" >
        <tr>
            <th>ID</th>
            <th>Yetenek</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID")  %></td>
                    <td><%# Eval("YETENEK")  %></td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YetenekSil.Aspx?ID=" + Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "YetenekGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-success" >Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <a href="YeniYetenek.Aspx" class="btn btn-primary" style="margin-left:20px;">Yeni Yetenek Ekle</a>



</asp:Content>