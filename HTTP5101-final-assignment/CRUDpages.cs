using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//It was mentioned that we needed to create a page class, 
//and this was made based on what I'd seen in class, and the example files.
//It was made to the best of my understanding, so I'm missing something, I feel.
namespace HTTP5101_final_assignment
{
    public class CRUDpages
    {
        private string blog_name;
        private string blog_body;
    }
    public string GetName() {
        return blog_name;
    }
    public string GetBody() {
        return blog_body;
    }
    public void SetName(string value) {
        blog_name = value;
    }
    public void SetBody(string value) {
        blog_body = value;
    }*/
}