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
        Playermodel player = new Playermodel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");   // Need to load the table we're going to insert into.

                //SQLDatabase.DatabaseRow new_row = cards_table.NewRow();    // Create a new based on the format of the rows in this table.

                //string new_id = cards_table.GetNextID().ToString();    // Use this to create a new ID number for this module. This new ID follows on from the last row's ID number.

                //new_row["name"] = "2C13";            // Card name
                //new_row["health"] = "3";
                //new_row["damage"] = "4";

                //cards_table.Insert(new_row);


                TextBox1.Text = "";






                Cardmodel[] card = new Cardmodel[12];

                //TextBox1.Text += card[0].GetData();
                //Image1.ImageUrl += card[0].GetImg();

                for (int i = 0; i < card.Length; ++i)
                {
                    card[i] = new Cardmodel(i);
                }

                //for (int i = 0; i < card.Length; ++i)
                //{
                //    TextBox1.Text += card[i].GetData() + "\n";
                //}
                //Image1.ImageUrl += card[0].GetImg();
                //Image2.ImageUrl += card[1].GetImg();
                //Image3.ImageUrl += card[2].GetImg();

                StringBuilder sb = new StringBuilder();

                sb.Append("<table>");
                for (int i = 0; i < card.Length; ++i)
                {
                    if(i==0 || i== card.Length / 2) sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("<img" + ' ' +"src=" + '"' + card[i].GetImg() + '"' + '>');
                    sb.Append(card[i].GetData() + "\n");
                    sb.Append("</th>");
                    if(i== (card.Length/2) - 1 || i== card.Length) sb.Append("</tr>");

                }
                sb.Append("</table>");

                   Panel1.Controls.Add(new Label { Text = sb.ToString() });
            }
        }
        protected void button1_Click(object sender, System.EventArgs e)
        {
            player.setName(TextBox1.Text.ToString());
            TextBox1.Text += player.getPlayerIdg();
            TextBox1.Text += player.getPlayerId();
        }
    }
}