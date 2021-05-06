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
                    <asp:TextBox ID="TextBox1" class="textboxreg" runat="server"></asp:TextBox>
                    <div runat="server" id="SelectDeckp1">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox2" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox3" runat="server" Visible="false" />
                                <asp:CheckBox ID="CheckBox4" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox5" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox6" runat="server" Visible="false"/>
                                <p runat="server" id="P1dcdeck">Dc Universe -Deck</p>
                                <asp:Button ID="Button2" runat="server" Text="DC Universe" OnClick="Button1_Click" />
                                <p runat="server" id="P1marveldeck">Marvel - Deck</p>
                                <asp:Button ID="Button3" runat="server" Text="Marvel" OnClick="Button2_Click" />  
                                <asp:Button ID="Button6" runat="server" Text="Attack" OnClick="Button6_Click"/>
                                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div id="player-2" class="controlls">
                    <asp:TextBox ID="TextBox2" class="textboxreg" runat="server"></asp:TextBox>
                    <div runat="server" id="SelectDeckp2">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
                            <ContentTemplate>
                                <asp:CheckBox ID="CheckBox7" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox8" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox9" runat="server" Visible="false" />
                                <asp:CheckBox ID="CheckBox10" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox11" runat="server" Visible="false"/>
                                <asp:CheckBox ID="CheckBox12" runat="server" Visible="false"/>
                                <p runat="server" id="P2dcdeck">Dc Universe -Deck</p>
                                <asp:Button ID="Button4" runat="server" Text="DC Universe" OnClick="Button3_Click"/>
                                <p runat="server" id="P2marveldeck">Marvel - Deck</p>
                                <asp:Button ID="Button5" runat="server" Text="Marvel" OnClick="Button4_Click" />
                                <asp:Button ID="Button7" runat="server" Text="Attack" OnClick="Button7_Click"/>
                                <asp:Panel ID="Panel2" runat="server"></asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <asp:Button ID="Button8" runat="server" Text="DELETE TEMPORARY TABLES BEFORE RUN" OnClick="DeleteTemp_Button"/>
                <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Regplayersbutton_Click" />
            </div>
        </div>
        
    </form>
</body>
</html>
