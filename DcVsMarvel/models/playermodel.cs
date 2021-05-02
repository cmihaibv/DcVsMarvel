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


        public string getPlayerId()
        {
            return PlayerId.ToString();
        }
        public string getPlayerIdg()
        {
            return Id.ToString();
        }
        public void setName(string name)
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