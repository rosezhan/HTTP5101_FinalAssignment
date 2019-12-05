using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_final_assignment
{
    public partial class viewpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //I created a ShowPageInfo in the database class, that didn't solve the issue.
            //I'm not sure what else is missing, but perhaps it's something in the Page_DB class.
            Page_DB db = new Page_DB();
            ShowPageInfo (db);
        }
        /*protected void DeletePage(object sender, EventArgs e)
        {
            bool valid = true;
            string page_number = Request.QueryString["page_number"];
            if (String.IsNullOrEmpty(page_number)) valid = false;

            Page_DB db = new Page_DB();

            if (valid)
            {
                db.DeletePage(Int32.Parse(page_number));
                Response.Redirect("userpages.aspx");
            }

        /*protected void ShowPageInfo(Page_DB db)
        {
                bool valid = true;
                string page_number = Request.QueryString["page_number"];
                if (String.IsNullOrEmpty(page_number)) valid = false;

                if (valid)
                {
                    CRUDpages page_record = db.FindPage(Int32.Parse(page_number));


                    page_title.InnerHtml = CRUDpages.GetName();
                    page_content.InnerHtml = CRUDpages.GetBody();
                }
                else
                {
                    valid = false;
                }


                if (!valid)
                {
                    page_title.InnerHtml = "There was an error finding that student.";
                }
            }
        }*/
    }
}