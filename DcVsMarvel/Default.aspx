<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DcVsMarvel.Default" %>

<!DOCTYPE html>

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

        <div>
    
            <span class="auto-style1">Cards:</span><br />    
            <asp:TextBox ID="TextBox1" runat="server" Rows="20" TextMode="MultiLine" Width="800px"></asp:TextBox>

            <br />
            <asp:DataList ID="DataList1" runat="server" >
                <ItemTemplate>
                    <table>
                        <tr style="font-family:Arial, Helvetica, sans-serif;font-size:12pt;">
                            <td style="width:100px;background-color:#f0f0f0;">
                                <asp:Label ID="ID_Label" runat="server" Text=""></asp:Label>
                            </td>
                            <td style="width:250px;background-color:#f0f0f0;">
                                <asp:Label ID="Name_Label" runat="server" Text=""></asp:Label>
                            </td>
                            <td style="width:100px;background-color:#f0f0f0;">
                                <asp:Label ID="Health_Label" runat="server" Text=""></asp:Label>
                            </td>
                            <td style="width:100px;background-color:#f0f0f0;">
                                <asp:Label ID="Damage_Label" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <div class="container">
            <asp:Image ID="Image1" runat="server" />
            <asp:Image ID="Image2" runat="server" />
            <asp:Image ID="Image3" runat="server" />
            <asp:CheckBox ID="CheckBox1" runat="server"/>
            </div>
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>

<script>
    $(document).lad(function ()
    {
        $(".cbox").hide();
        $(".container img").click(function () {
            //do the stuff you need to do like
        var checkbox = $(this).parent().find(".cbox");
        checkbox.attr('checked', !$checkbox.attr('checked'));
    });
    });</script>


        </div>        
       
    </form>
</body>
</html>
