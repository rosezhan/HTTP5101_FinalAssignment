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
            Page_DB db = new Page_DB();
            ShowPageInfo(db);
        }
        protected void DeletePage(object sender, EventArgs e)
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

        protected void ShowPageInfo(Page_DB db)
        {
                bool valid = true;
                string page_number = Request.QueryString["page_number"];
                if (String.IsNullOrEmpty(page_number)) valid = false;

                if (valid)
                {

                    Student student_record = db.FindStudent(Int32.Parse(studentid));


                    student_title_fname.InnerHtml = student_record.GetFname() + " " + student_record.GetLname();
                    student_fname.InnerHtml = student_record.GetFname();
                    student_lname.InnerHtml = student_record.GetLname();
                    student_number.InnerHtml = student_record.GetNumber();
                    enrolment_date.InnerHtml = student_record.GetEnrolDate().ToString("yyyy-M-dd");
                }
                else
                {
                    valid = false;
                }


                if (!valid)
                {
                    student.InnerHtml = "There was an error finding that student.";
                }
            }
        }
    }
}