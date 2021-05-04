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

        protected void Button1_Click(object sender, EventArgs e)                        //player1 button dc deck
        {
            Panel1.Controls.Add(new Label { Text = DcDeckBuilder(1).ToString() });
            Button2.Visible = false;
            Button3.Visible = false;
            P1dcdeck.Visible = false;
            P1marveldeck.Visible = false;
            Button7.Visible = false;
            UpdateCheckBox(1);
        }
        protected void Button2_Click(object sender, EventArgs e)                        //player1 button marvel deck
        {
            Panel1.Controls.Add(new Label { Text = MarvelDeckBuilder(1).ToString() });
            Button2.Visible = false;
            Button3.Visible = false;
            P1dcdeck.Visible = false;
            P1marveldeck.Visible = false;
            Button7.Visible = false;
            UpdateCheckBox(1);
        }
        protected void Button3_Click(object sender, EventArgs e)                        //player2 button dc deck
        {
            Panel2.Controls.Add(new Label { Text = DcDeckBuilder(2).ToString() });
            Button4.Visible = false;
            Button5.Visible = false;
            P2dcdeck.Visible = false;
            P2marveldeck.Visible = false;
            Button7.Visible = false;
            UpdateCheckBox(2);
        }
        protected void Button4_Click(object sender, EventArgs e)                        //player2 button marvel deck
        {
            Panel2.Controls.Add(new Label { Text = MarvelDeckBuilder(2).ToString() });
            Button4.Visible = false;
            Button5.Visible = false;
            P2dcdeck.Visible = false;
            P2marveldeck.Visible = false;
            Button7.Visible = false;
            UpdateCheckBox(2);
        }
        protected void Button6_Click(object sender, EventArgs e)                        //player2 button marvel deck
        {
            DoJob();
            Button6.Visible = false;
            Button7.Visible = true;
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            DoJob();
            Button7.Visible = false;
            Button6.Visible = true;
        }
        protected void DoJob()
        {
            if (player1.DeckName(1) == "dc")
                Panel1.Controls.Add(new Label { Text = DcDeckBuilder(1).ToString() });
            if (player1.DeckName(1) == "marvel")
                Panel1.Controls.Add(new Label { Text = MarvelDeckBuilder(1).ToString() });
            if (player1.DeckName(1) == "dc")
                Panel2.Controls.Add(new Label { Text = DcDeckBuilder(2).ToString() });
            if (player1.DeckName(1) == "marvel")
                Panel2.Controls.Add(new Label { Text = MarvelDeckBuilder(2).ToString() });
            UpdateCheckBox(1);
            UpdateCheckBox(2);
        }

        protected StringBuilder DcDeckBuilder(int playerid)                             //dc deck builder
        {
            StringBuilder sb = new StringBuilder();
            
           
            if (playerid == 1)                      //deck for player1
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
            else if (playerid == 2)                 //deck for player2
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

        protected StringBuilder MarvelDeckBuilder(int playerid)                             //marvel deck builder
        {

            StringBuilder sb = new StringBuilder();

            if (playerid == 1)                      //deck for player1
            {
                player1.setPlayerHand(2);
                sb.Append("<table>");
                for (int i = 0; i < player1.Playerhand.Length; ++i)
                {
                    if(player1.isCardAlive(i)==true)
                    {
                        if (i == 0) sb.Append("<tr>");
                        sb.Append("<th>");
                        sb.Append("<img" + ' ' + "src=" + '"' + player1.getPlayerCardImg(i) + '"' + '>');
                        sb.Append(player1.getPlayerCard(i) + "\n");
                        sb.Append("</th>");
                        if (i == player1.Playerhand.Length) sb.Append("</tr>");
                    }

                }
                sb.Append("</table>");
            }
            else if (playerid == 2)                 //deck for palyer2
            {
                player2.setPlayerHand(2);

                sb.Append("<table>");
                for (int i = 0; i < player2.Playerhand.Length; ++i)
                {
                    if(player2.isCardAlive(i)==true)
                    {
                        if (i == 0) sb.Append("<tr>");
                        sb.Append("<th>");
                        sb.Append("<img" + ' ' + "src=" + '"' + player2.getPlayerCardImg(i) + '"' + '>');
                        sb.Append(player2.getPlayerCard(i) + "\n");
                        sb.Append("</th>");
                        if (i == player2.Playerhand.Length) sb.Append("</tr>");
                    }
                }
                sb.Append("</table>");
            }
            return sb;
        }
        protected void CheckedBoxes()
        {
            int cardidp1=0;
            int cardidp2=0;
            if (CheckBox1.Checked == true)
                cardidp1 = 0;
            if (CheckBox2.Checked==true)
                cardidp1 = 1;
            if (CheckBox3.Checked == true)
                cardidp1 = 2;
            if (CheckBox4.Checked == true)
                cardidp1 = 3;
            if (CheckBox5.Checked == true)
                cardidp1 = 4;
            if (CheckBox6.Checked == true)
                cardidp1 = 5;
            if (CheckBox7.Checked == true)
                cardidp2 = 0;
            if (CheckBox8.Checked == true)
                cardidp2 = 1;
            if (CheckBox9.Checked == true)
                cardidp2 = 2;
            if (CheckBox10.Checked == true)
                cardidp2 = 3;
            if (CheckBox11.Checked == true)
                cardidp2 = 4;
            if (CheckBox12.Checked == true)
                cardidp2 = 5;

            player1.RetCard(cardidp1).Cardhealth = player1.RetCard(cardidp1).Cardhealth - player2.RetCard(cardidp2).Cardhealth;
            player2.RetCard(cardidp2).Cardhealth = player2.RetCard(cardidp2).Cardhealth - player1.RetCard(cardidp1).Cardhealth;
        }
        //update checkboxlist 
        protected void UpdateCheckBox(int playerid)
        {
            CheckBox1.ID = 1.ToString();

            if(playerid==1)
            {
                if (player1.isCardAlive(0) == true)
                    CheckBox1.Visible = true;
                else
                    CheckBox1.Visible = false;
                if (player1.isCardAlive(1) == true)
                    CheckBox2.Visible = true;
                else
                    CheckBox2.Visible = false;
                if (player1.isCardAlive(2) == true)
                    CheckBox3.Visible = true;
                else
                    CheckBox3.Visible = false;
                if (player1.isCardAlive(3) == true)
                    CheckBox4.Visible = true;
                else
                    CheckBox4.Visible = false;
                if (player1.isCardAlive(4) == true)
                    CheckBox5.Visible = true;
                else
                    CheckBox5.Visible = false;
                if (player1.isCardAlive(5) == true)
                    CheckBox6.Visible = true;
                else
                    CheckBox6.Visible = false;
            }
            else if(playerid==2)
            {
                if (player2.isCardAlive(0) == true)
                    CheckBox7.Visible = true;
                else
                    CheckBox7.Visible = false;
                if (player2.isCardAlive(1) == true)
                    CheckBox8.Visible = true;
                else
                    CheckBox8.Visible = false;
                if (player2.isCardAlive(2) == true)
                    CheckBox9.Visible = true;
                else
                    CheckBox9.Visible = false;
                if (player2.isCardAlive(3) == true)
                    CheckBox10.Visible = true;
                else
                    CheckBox10.Visible = false;
                if (player2.isCardAlive(4) == true)
                    CheckBox11.Visible = true;
                else
                    CheckBox11.Visible = false;
                if (player2.isCardAlive(5) == true)
                    CheckBox12.Visible = true;
                else
                    CheckBox12.Visible = false;
            }

        }
    }
}