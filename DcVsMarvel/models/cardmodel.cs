using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcVsMarvel.models
{
    public class Cardmodel
    {
        public int Id { get; set; }
        public int Cardid { get; set; }
        public string Cardname { get; set; }
        public int Cardhealth { get; set; }
        public int Carddamage { get; set; }
        public string Imageurl { get; set; }
        public string Deckname { get; set; }
        public bool Cardalive { get; set; }

        public Cardmodel(int theid, int playerid)
        {
            SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("deck_"+ playerid);   // Need to load the table we're going to insert into.
            Id = theid;
            Cardid = Int32.Parse(cards_table.GetRow(Id)["id"]);
            Cardname = cards_table.GetRow(Id)["name"];
            Cardhealth = Int32.Parse(cards_table.GetRow(Id)["health"]);
            Carddamage = Int32.Parse(cards_table.GetRow(Id)["damage"]);
            Imageurl = cards_table.GetRow(Id)["image"];
            Deckname = cards_table.GetRow(Id)["deckname"];
            Cardalive = true;
        }


        public string GetData()
        {
            return Cardid + "\t" + Cardname + "\t" + Cardhealth + "\t" + Carddamage + "\n";
        }


        public string GetImg()
        {
            return Imageurl;
        }

        public bool IsAlive()
        {
            Cardalive = false;

            if (Cardhealth > 0)
                Cardalive = true;

            return Cardalive;
        }
    }
}