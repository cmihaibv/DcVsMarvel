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

                Cardmodel[] card = new Cardmodel[12];


                for (int i = 0; i < card.Length; ++i)
                {
                    card[i] = new Cardmodel(i);
                }

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
        protected void button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "" && TextBox2.Text != "")
            { 
            player1.setName(TextBox1.Text.ToString());

            player2.setName(TextBox2.Text.ToString());

                TextBox1.ReadOnly = true;
                TextBox2.ReadOnly = true;
                Button1.Visible = false;
            }
            else
                TextBox1.Text += "All players must have a name";

        }
    }
}