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
        Cardmodel[] cards;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
                Button6.Visible = false;
                Button7.Visible = false;
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

        protected void DeleteTemp_Button(object sender, EventArgs e)
        {
            DeleteTemporaryTables();
            Button8.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)                        //player1 button dc deck deck_1
        {
            player1.SetDeckToPlayer(1, "deckname" , "dc");
            player1.CreateDeck(1, "dc");
            GetPlayerHand(1);
            Panel1.Controls.Add(new Label { Text = DisplayCards().ToString() });
            Button2.Visible = false;
            Button3.Visible = false;
            P1dcdeck.Visible = false;
            P1marveldeck.Visible = false;
            Button6.Visible = true;
            Button7.Visible = false;
            UpdateCheckBox(1);

        }
        protected void Button2_Click(object sender, EventArgs e)                        //player1 button marvel deck
        {
            player1.SetDeckToPlayer(1, "deckname", "marvel");
            player1.CreateDeck(1, "marvel");
            GetPlayerHand(1);
            Panel1.Controls.Add(new Label { Text = DisplayCards().ToString() });
            Button2.Visible = false;
            Button3.Visible = false;
            P1dcdeck.Visible = false;
            P1marveldeck.Visible = false;
            Button6.Visible = true;
            Button7.Visible = false;
            UpdateCheckBox(1);
        }
        protected void Button3_Click(object sender, EventArgs e)                        //player2 button dc deck
        {
            player2.SetDeckToPlayer(2, "deckname", "dc");
            player2.CreateDeck(2, "dc");
            GetPlayerHand(2);
            Panel2.Controls.Add(new Label { Text = DisplayCards().ToString() });
            Button4.Visible = false;
            Button5.Visible = false;
            P2dcdeck.Visible = false;
            P2marveldeck.Visible = false;
            Button7.Visible = false;
            UpdateCheckBox(2);
        }
        protected void Button4_Click(object sender, EventArgs e)                        //player2 button marvel deck
        {
            player2.SetDeckToPlayer(2, "deckname", "marvel");
            player2.CreateDeck(2, "marvel");
            GetPlayerHand(2);
            Panel2.Controls.Add(new Label { Text = DisplayCards().ToString() });
            Button4.Visible = false;
            Button5.Visible = false;
            P2dcdeck.Visible = false;
            P2marveldeck.Visible = false;
            Button7.Visible = false;
            UpdateCheckBox(2);
        }
        protected void Button6_Click(object sender, EventArgs e)                        //player1 attack
        {
            Button6.Visible = false;
            Button7.Visible = true;
            //DoJob();
            UpdatePanel();
        }
        protected void Button7_Click(object sender, EventArgs e)                        //player1 attack
        {
            Button6.Visible = true;
            Button7.Visible = false;
            //DoJob();
            UpdatePanel();
        }

        protected void UpdatePanel()
        {
            GetPlayerHand(1);
            Panel1.Controls.Add(new Label { Text = DisplayCards().ToString() });
            GetPlayerHand(2);
            Panel2.Controls.Add(new Label { Text = DisplayCards().ToString() });
        }
        protected StringBuilder DisplayCards()                             //dc deck builder
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<table>");
            for (int i = 0; i < cards.Length; ++i)
            {
                if (cards[i].IsAlive() == true)
                {
                    if (i == 0) sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("<img" + ' ' + "src=" + '"' + cards[i].GetImg() + '"' + '>');
                    sb.Append(cards[i].GetData() + "\n");
                    sb.Append("</th>");
                    if (i == cards.Length) sb.Append("</tr>");
                }
            }
            sb.Append("</table>");


            return sb;
        }

        public void GetPlayerHand(int playerid) // get the deck of a player from db
        {
            cards = new Cardmodel[6];
            SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("deck_" + playerid);

            //Cardmodel[] tempcards = new Cardmodel[cards_table.RowCount];

            for (int i = 0; i < cards_table.RowCount; ++i)
            {
                cards[i] = new Cardmodel(i, playerid);
            }
        }

        protected int Selectedcard(int playerid)
        {
            int cardid=0;
            if(playerid == 1)
            {
                if (CheckBox1.Checked == true)
                    cardid = 0;
                if (CheckBox2.Checked == true)
                    cardid = 1;
                if (CheckBox3.Checked == true)
                    cardid = 2;
                if (CheckBox4.Checked == true)
                    cardid = 3;
                if (CheckBox5.Checked == true)
                    cardid = 4;
                if (CheckBox6.Checked == true)
                    cardid = 5;
            }

            if(playerid ==2)
            {
                if (CheckBox7.Checked == true)
                    cardid = 0;
                if (CheckBox8.Checked == true)
                    cardid = 1;
                if (CheckBox9.Checked == true)
                    cardid = 2;
                if (CheckBox10.Checked == true)
                    cardid = 3;
                if (CheckBox11.Checked == true)
                    cardid = 4;
                if (CheckBox12.Checked == true)
                    cardid = 5;
            }

            return cardid;
        }
        //update checkboxlist 
        protected void UpdateCheckBox(int playerid)
        {

            if(playerid==1)
            {
                if (cards[0].IsAlive() == true)
                    CheckBox1.Visible = true;
                else
                    CheckBox1.Visible = false;
                if (cards[1].IsAlive() == true)
                    CheckBox2.Visible = true;
                else
                    CheckBox2.Visible = false;
                if (cards[2].IsAlive() == true)
                    CheckBox3.Visible = true;
                else
                    CheckBox3.Visible = false;
                if (cards[3].IsAlive() == true)
                    CheckBox4.Visible = true;
                else
                    CheckBox4.Visible = false;
                if (cards[4].IsAlive() == true)
                    CheckBox5.Visible = true;
                else
                    CheckBox5.Visible = false;
                if (cards[5].IsAlive() == true)
                    CheckBox6.Visible = true;
                else
                    CheckBox6.Visible = false;
            }
            else if(playerid==2)
            {
                if (cards[0].IsAlive() == true)
                    CheckBox7.Visible = true;
                else
                    CheckBox7.Visible = false;
                if (cards[1].IsAlive() == true)
                    CheckBox8.Visible = true;
                else
                    CheckBox8.Visible = false;
                if (cards[2].IsAlive() == true)
                    CheckBox9.Visible = true;
                else
                    CheckBox9.Visible = false;
                if (cards[3].IsAlive() == true)
                    CheckBox10.Visible = true;
                else
                    CheckBox10.Visible = false;
                if (cards[4].IsAlive() == true)
                    CheckBox11.Visible = true;
                else
                    CheckBox11.Visible = false;
                if (cards[5].IsAlive() == true)
                    CheckBox12.Visible = true;
                else
                    CheckBox12.Visible = false;
            }

        }
        protected void DoJob()
        {

            //GetPlayerHand(1);

            //GetPlayerHand(2);
            //Card1Health = cards[Selectedcard(2)].Cardhealth;
            //Card1Damage = cards[Selectedcard(2)].Carddamage;


            //int result = b - a;
            //int result2 = a - b;
            //GetPlayerHand(1);
            //UpdateCheckBox(1);

            //GetPlayerHand(2);
            //UpdateCheckBox(2);

        }

        protected void DeleteTemporaryTables()
        {
            SQLDatabase.DatabaseTable temp = new SQLDatabase.DatabaseTable("GamePlayers");

            temp.DeleteTemp();
        }
    }
}