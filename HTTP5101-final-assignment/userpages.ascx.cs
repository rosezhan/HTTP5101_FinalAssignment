using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_final_assignment
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page_DB db = new Page_DB();
            ListNewPages(db);
        }
        protected void ListNewPages(Page_DB db)
        {
            string query = "select page_name from PAGES";
            List<Dictionary<string, string>> ds = db.QueryList(query);

            foreach (Dictionary<string, string> row in ds)
            {
                blog_pages.InnerHtml += row["page_name"] + "<br>";
            }
        }

    }
}
