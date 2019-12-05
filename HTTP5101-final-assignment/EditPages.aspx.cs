using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_final_assignment
{
    public partial class editpages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page_DB db = new Page_DB();
                ShowPageInfo(db);
            }
        }

        protected void Update_Page(object sender, EventArgs e)
        {

            Page_DB db = new Page_DB();

            bool valid = true;
            string page_number = Request.QueryString["page_number"];
            if (String.IsNullOrEmpty(page_number)) valid = false;
            if (valid)
            {
                CRUDpages new_page = new CRUDpages();
             
                new_page.SetName(page_title.Text);
                new_page.SetBody(page_content.Text);

                try
                {
                    db.UpdatePage(Int32.Parse(page_number), new_page);
                    Response.Redirect("ShowPage.aspx?page_number=" + page_number);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                page_title.InnerHtml = "There was an error updating that student.";
            }

        }

        protected void ShowPageInfo(Page_DB db)
        {

            bool valid = true;
            string page_number = Request.QueryString["page_number"];
            if (String.IsNullOrEmpty(page_number)) valid = false;

            if (valid)
            {

                CRUDpages page_record = db.FindPage(Int32.Parse(page_number));
                page_title.InnerHtml = CRUDpages.GetName();
                page_body.Text = CRUDpages.GetBody();
            }

            if (!valid)
            {
                page_title.InnerHtml = "There was an error finding that page.";
            }
        }
    }
}
    
