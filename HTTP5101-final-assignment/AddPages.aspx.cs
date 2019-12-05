using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_final_assignment
{
    public partial class AddPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page_DB db = new Page_DB();

            CRUDpages new_page = new CRUDpages();
            new CRUDpages.SetName(page_title.text);
            new CRUDpages.SetBody(page_body.text);

            db.addpage(new_page);

            Response.Redirect("ViewPages.aspx");
        }
    }
}