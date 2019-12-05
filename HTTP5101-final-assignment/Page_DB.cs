using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

//code referenced from in-class example, made by Christine Bittle.

namespace HTTP5101_final_assignment
{
    public class Page_DB
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "crud_blog"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }  
        //The QueryList is indeed referenced elsewhere, but perhaps I'm not using it in the right way. 
        //public List<Dictionary<String, String>> QueryList(string query)
        
        //{
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
        }

        /*/This section is for showing page info, as referenced in a previous file.
        ///To be honest, I'm not sure where the problem lies.
        //As I have yet to even figure out this one problem with the QueryList, I have not moved on.
        //I think the problem lies not in the code itself but perhaps in something that I do not yet understand.
        public void ShowPageInfo(CRUDpages list_pages)
        {
            string query = "select page_name, page_body from pages";
            query = String.Format(query, list_pages.GetName(), list_pages.GetBody());

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
        }*/
        /*
        public void AddPage(CRUDpages new_page)
        {
            string query = "insert into pages(page_name, page_body) values ('{0}','{1})";
            query = String.Format(query, new_page.GetName(), new_page.GetBody());

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


        /*public void UpdatePage(int page_number, Pages new_page)
        {
            string query = "update pages set page_name='{0}', page_body='{1}'";
            query = String.Format(query, new_page.Getname(), new_page.Getbody())

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the UpdatePage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void DeletePage(int page_number)
        {
            string RemovePage = "delete from pages where page_number = {0}";
            RemovePage = String.Format(RemovePage, page_number);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd_RemovePage = new MySqlCommand(RemovePage, Connect);
            try
            {
                Connect.Open();
                cmd_RemovePage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_RemovePage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the delete pages Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }*/
    }
//}

       