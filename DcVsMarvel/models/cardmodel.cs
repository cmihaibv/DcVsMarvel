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

        public Cardmodel(int theid)
        {
            SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");   // Need to load the table we're going to insert into.
            Id = theid;
            Cardid = Int32.Parse(cards_table.GetRow(Id)["id"]);
            Cardname = cards_table.GetRow(Id)["name"];
            Cardhealth = Int32.Parse(cards_table.GetRow(Id)["health"]);
            Carddamage = Int32.Parse(cards_table.GetRow(Id)["damage"]);
            Imageurl = cards_table.GetRow(Id)["image"];
            Deckname = cards_table.GetRow(Id)["deckname"];
        }


        public string GetData()
        {
            //SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");   // Need to load the table we're going to insert into.

            //return cards_table.GetRow(id)["id"] + "\t"+ cards_table.GetRow(id)["name"] + "\t" + cards_table.GetRow(id)["health"] + "\t" + cards_table.GetRow(id)["damage"] + "\n";

            return Cardid + "\t" + Cardname + "\t" + Cardhealth + "\t" + Carddamage + "\n";

        }


        public string GetImg()
        {
            //SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");

            //imageurl = cards_table.GetRow(id)["image"];

            return Imageurl;
        }

        public string GetDeckName()
        {
            return Deckname;
        }
    }
}