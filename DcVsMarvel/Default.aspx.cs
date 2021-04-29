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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SQLDatabase.DatabaseTable cards_table = new SQLDatabase.DatabaseTable("Cards");   // Need to load the table we're going to insert into.

                cards_table.Bind(DataList1);

                Cardmodel[] card = new Cardmodel[3];

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
                sb.Append("<tr>");
                for (int i = 0; i < card.Length; ++i)
                {
                    sb.Append("<th>");
                    sb.Append(TextBox1.Text += card[i].GetData() + "\n");
                    sb.Append("</th>");
                }

                sb.Append("</tr>");
                sb.Append("</table>");

                Panel1.Controls.Add(new Label { Text = sb.ToString() });




            }
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            //if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            //{
            //    DataListItem i = e.Item;
            //    System.Data.DataRowView r = ((System.Data.DataRowView)e.Item.DataItem); // 'r' represents the next row in the table that has been passed here via the 'bind' function.

            //    // Find the label controls that are associated with this data item.
            //    Label ID_LBL = (Label)e.Item.FindControl("ID_Label");           // Find the ID Label.
            //    Label Name_LBL = (Label)e.Item.FindControl("Name_Label");       // Find the Name Label.
            //    Label Health_LBL = (Label)e.Item.FindControl("Health_Label"); // Find the Staff ID Label.
            //    Label Damage_LBL = (Label)e.Item.FindControl("Damage_Label"); // Find the Staff ID Label.


            //    ID_LBL.Text = r["id"].ToString();               // Now we have the labels, we can insert the data...   ID number first,
            //    Name_LBL.Text = r["name"].ToString();           // Module name.
            //    Health_LBL.Text = r["health"].ToString();     // Staff ID number.
            //    Damage_LBL.Text = r["damage"].ToString();     // Staff ID number.
            //}
        }
    }
}