using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcVsMarvel.models
{
    public class Playermodel
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Playername { get; set; }
        public int Playerwins { get; set; }
        public int Playerloses { get; set; }
        public Cardmodel[] Playerhand { get; set; }

        public void setPlayerHand(int decknum) // set the deck of a player
        {
            Playerhand = new Cardmodel[6];

            SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");

            Cardmodel[] tempcards = new Cardmodel[cards_table.RowCount];

            for (int i = 0; i < cards_table.RowCount; ++i)
            {
                tempcards[i] = new Cardmodel(i);
            }

            int r = 0;
            if(decknum==1) // dc universe deck
            {
                for (int i = 0; i < cards_table.RowCount; ++i)
                {
                    if (tempcards[i].GetDeckName() == "dc")
                    {
                        Playerhand[r] = tempcards[i];
                        r++;
                    }
                }
            }
            else if(decknum==2) // marvel deck
            {
                for (int i = 0; i < cards_table.RowCount; ++i)
                {
                    if (tempcards[i].GetDeckName() == "marvel")
                    {
                        Playerhand[r] = tempcards[i];
                        r++;
                    }
                }
            }
        }
        public string getPlayerCard(int cardid)         //return card data
        {
            return Playerhand[cardid].GetData(); 
        }
        public string getPlayerCardImg(int cardid)      //return image of card
        {
            return Playerhand[cardid].GetImg();
        }
        public string getPlayerId()                  //player user Id in database
        {
            return PlayerId.ToString();
        }
        public string getPlayerIdg()                //player user Id
        {
            return Id.ToString();
        }

        
        public void setName(string name)    //find if user exist in database, add it if new user
        {
            Playername = name;

            SQLDatabase.DatabaseTable players_table = new SQLDatabase.DatabaseTable("Players");
            SQLDatabase.DatabaseRow new_row = players_table.NewRow();

            string[] names = new string[players_table.RowCount];

            int tempid=0;
            bool match = false;
            for (int r = 0; r < players_table.RowCount; ++r)
            {  
                tempid = Int32.Parse(players_table.GetRow(r)["id"]);
                names[r] = players_table.GetRow(r)["name"];
                if (names[r] == Playername)
                {
                    Id = r;
                    PlayerId = tempid;
                    r = players_table.RowCount;
                    match = true;
                }
                else
                {
                    Id = r + 1;
                    PlayerId = tempid + 1;
                }
                tempid++;
            }
            if(match != true)
            {
                new_row["name"] = Playername;

                players_table.Insert(new_row);
            }


        }
    }
}