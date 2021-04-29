using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcVsMarvel.models
{
    public class Cardmodel
    {
        public int id { get; set; }
        public string cardname { get; set; }
        public int cardhealth { get; set; }
        public int carddamage { get; set; }
        public string imageurl { get; set; }

        public Cardmodel(int theid)
        {
            SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");   // Need to load the table we're going to insert into.
            id = theid;
            cardname = cards_table.GetRow(id)["name"];
            cardhealth = Int32.Parse(cards_table.GetRow(id)["health"]);
            carddamage = Int32.Parse(cards_table.GetRow(id)["damage"]);
            imageurl = cards_table.GetRow(id)["image"];
        }


        public string GetData()
        {
            //SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");   // Need to load the table we're going to insert into.

            //return cards_table.GetRow(id)["id"] + "\t"+ cards_table.GetRow(id)["name"] + "\t" + cards_table.GetRow(id)["health"] + "\t" + cards_table.GetRow(id)["damage"] + "\n";

            return id + cardname + cardhealth + carddamage;

        }


        public string GetImg()
        {
            //SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");

            //imageurl = cards_table.GetRow(id)["image"];

            return imageurl;
        }
    }
}