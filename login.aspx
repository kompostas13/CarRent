﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1 {
            width: 902px;
            height: 259px;
        }
    </style>
</head>
<body text="blue";background-image: url("D:\repos HDD\RentACarWebsite\car2.jpg"); style="height: 401px">

    

    <form id="form1" runat="server">

    

    <h4 align="center" align="top" style="font-size:400%;">RENT-A-CAR</h4>
        <p style="width: 100px; font-size:130%; margin-bottom: 20px;">
            Username :<asp:TextBox ID="username_text" runat="server" style="margin-bottom: 4px" Width="128px"></asp:TextBox>
        </p>
        <p style="width: 100px; font-size:130%; height: 20px; margin-bottom: 38px;">
            Password :<asp:TextBox ID="password_text" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password" Width="140px" Height="16px" style="margin-left: 1px; margin-bottom: 0px;"></asp:TextBox>
        </p>
        <asp:Button ID="login_button" runat="server" Text="LOGIN" OnClick="login_button_Click" Height="31px" Width="67px" />

        <p>
            New to our site ?<asp:Button ID="create_account_button" runat="server" OnClick="create_account_button_Click" style="margin-left: 11px" Text="CREATE ACCOUNT" />
        </p>
    

    </form>
    

</body>
</html>
