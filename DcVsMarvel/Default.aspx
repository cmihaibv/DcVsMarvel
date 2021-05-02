<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DcVsMarvel.Default" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="/style.css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 10pt;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main-content">
            <div id="game-content">
                <div id="player-1" class="controlls">
                    <asp:TextBox ID="TextBox1" runat="server">Put your name here</asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Go" OnClick="button1_Click" />
                </div>

                <div id="player-2" class="controlls">
                    <asp:TextBox ID="TextBox2" runat="server">Put your name here</asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Go" />
                </div>
            </div>
        </div>
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    </form>
</body>
</html>
