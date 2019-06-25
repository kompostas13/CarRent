<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>hiii</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="background-color:#077390; width:100%; heigth:100%">
        <h4 align="center" style="font-size:400%;">RENT-A-CAR</h4>
    </div>
    <div style="font-size:200%;">

        <asp:Label ID="find_label" runat="server" Text="Find a car to rent :"></asp:Label>
        <asp:Button ID="find_button" runat="server" Text="FIND" Height="32px" OnClick="find_button_Click" Width="80px" />

    </div>
        
        

    </form>
        
        

</body>
</html>
