using DcVsMarvel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace DcVsMarvel
{
    public partial class Default : System.Web.UI.Page
    {
        Playermodel player1 = new Playermodel();
        Playermodel player2 = new Playermodel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
                SelectDeckp1.Visible = false;
                SelectDeckp2.Visible = false;

            }
        }
        protected void Regplayersbutton_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "" && TextBox2.Text != "")
            { 
            player1.setName(TextBox1.Text.ToString());

            player2.setName(TextBox2.Text.ToString());

                TextBox1.ReadOnly = true;
                TextBox2.ReadOnly = true;
                Button1.Visible = false;

                Button2.Visible = true;
                Button3.Visible = true;
                Button4.Visible = true;
                Button5.Visible = true;
                SelectDeckp1.Visible = true;
                SelectDeckp2.Visible = true;
            }
            else
                TextBox1.Text += "All players must have a name";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Add(new Label { Text = DcDeckBuilder(1).ToString() });
            Button2.Visible = false;
            Button3.Visible = false;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Add(new Label { Text = MarvelDeckBuilder(1).ToString() });
            Button2.Visible = false;
            Button3.Visible = false;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Add(new Label { Text = DcDeckBuilder(2).ToString() });
            Button4.Visible = false;
            Button5.Visible = false;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Add(new Label { Text = MarvelDeckBuilder(2).ToString() });
            Button4.Visible = false;
            Button5.Visible = false;
        }

        protected StringBuilder DcDeckBuilder(int playerid)
        {
            StringBuilder sb = new StringBuilder();

            if (playerid == 1)
            {
                player1.setPlayerHand(1);

                sb.Append("<table>");
                for (int i = 0; i < player1.Playerhand.Length; ++i)
                {
                    if (i == 0) sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("<img" + ' ' + "src=" + '"' + player1.getPlayerCardImg(i) + '"' + '>');
                    sb.Append(player1.getPlayerCard(i) + "\n");
                    sb.Append("</th>");
                    if (i == player1.Playerhand.Length) sb.Append("</tr>");

                }
                sb.Append("</table>");

            }
            else if (playerid == 2)
            {
                player2.setPlayerHand(1);

                sb.Append("<table>");
                for (int i = 0; i < player2.Playerhand.Length; ++i)
                {
                    if (i == 0) sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("<img" + ' ' + "src=" + '"' + player2.getPlayerCardImg(i) + '"' + '>');
                    sb.Append(player2.getPlayerCard(i) + "\n");
                    sb.Append("</th>");
                    if (i == player2.Playerhand.Length) sb.Append("</tr>");

                }
                sb.Append("</table>");

            }
            return sb;
        }

        protected StringBuilder MarvelDeckBuilder(int playerid)
        {

            StringBuilder sb = new StringBuilder();

            if (playerid == 1)
            {
                player1.setPlayerHand(2);
                sb.Append("<table>");
                for (int i = 0; i < player1.Playerhand.Length; ++i)
                {
                    if (i == 0) sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("<img" + ' ' + "src=" + '"' + player1.getPlayerCardImg(i) + '"' + '>');
                    sb.Append(player1.getPlayerCard(i) + "\n");
                    sb.Append("</th>");
                    if (i == player1.Playerhand.Length) sb.Append("</tr>");

                }
                sb.Append("</table>");
            }
            else if (playerid == 2)
            {
                player2.setPlayerHand(2);

                sb.Append("<table>");
                for (int i = 0; i < player2.Playerhand.Length; ++i)
                {
                    if (i == 0) sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("<img" + ' ' + "src=" + '"' + player2.getPlayerCardImg(i) + '"' + '>');
                    sb.Append(player2.getPlayerCard(i) + "\n");
                    sb.Append("</th>");
                    if (i == player2.Playerhand.Length) sb.Append("</tr>");

                }
                sb.Append("</table>");
            }
            return sb;
        }
    }
}