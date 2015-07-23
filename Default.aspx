<%@ Page Title="Posts" MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:20px;text-align:left;font-weight:bold;margin-bottom:10px;">
    Posts:
        <asp:Label ID="lblPCount" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div style="margin-bottom: 20px;">
                    <p style="margin:0px;text-align:center;"><hr style="margin:auto;width:250px;" /></p>
                    <h1><%# Eval("PostTitle") %></h1>
                    <p style="margin-top:0px;"><%# Eval("PostText") %></p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>