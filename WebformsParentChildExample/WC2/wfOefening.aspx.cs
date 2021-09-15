using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WC2
{
    public partial class wfOefening : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridViewGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewGames.SelectedRow;
            var id = Int32.Parse(row.Cells[1].Text);
            this.Session["SelectedParentId"] = id;
            Label1.Text = row.Cells[1].Text;
        }

    }
}