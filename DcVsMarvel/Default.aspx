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
         <asp:ScriptManager EnablePartialRendering="true"
 ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="main-content">
            <div id="game-content">
                <div id="player-1" class="controlls">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <div runat="server" id="SelectDeckp1">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <p>Dc Universe -Deck</p>
                                <asp:Button ID="Button2" runat="server" Text="DC Universe" OnClick="Button1_Click" />
                                <p>Marvel - Deck</p>
                                <asp:Button ID="Button3" runat="server" Text="Marvel" OnClick="Button2_Click" />  
                                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div id="player-2" class="controlls">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <div runat="server" id="SelectDeckp2">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <p>Dc Universe -Deck</p>
                                <asp:Button ID="Button4" runat="server" Text="DC Universe" OnClick="Button3_Click"/>
                                <p>Marvel - Deck</p>
                                <asp:Button ID="Button5" runat="server" Text="Marvel" OnClick="Button4_Click" />
                                <asp:Panel ID="Panel2" runat="server"></asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Regplayersbutton_Click" />
            </div>
        </div>
        
    </form>
</body>
</html>
