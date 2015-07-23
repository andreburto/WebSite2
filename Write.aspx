<%@ Page Title="Write" MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Write.aspx.cs" Inherits="Write" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:20px;text-align:left;font-weight:bold;margin-bottom:10px;">
    Write A Post
    </div>          
    <div style="height:auto;text-align:left;margin-bottom:10px;">
        Title:<br />
        <asp:TextBox ID="txtTitle" runat="server" Width="200px"></asp:TextBox>
    
    </div>
    <div style="height:auto;text-align:left;margin-bottom:10px;">
        Post Text:<br />
        <asp:TextBox ID="txtPost" runat="server" TextMode="MultiLine" Height="200px" Width="400px"></asp:TextBox>
    </div>
    <div style="height:auto;text-align:left;margin-bottom:10px;">
        <asp:Button ID="btnPost" runat="server" Text="Post" OnClick="btnPost_Click" Width="150px" />
    </div>
    <div style="height:auto;text-align:left;margin-bottom:10px;">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>