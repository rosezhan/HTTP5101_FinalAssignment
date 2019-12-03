using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

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
        public List<Dictionary<String, String>> QueryList(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
        }
        public void AddPage(Pages new_page)
        {
            string query = "insert into pages(page_name, page_body) values ('{0}','{1})";
            query = String.Format(query, new_page.Getname(), new_page.Getbody());

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


        public void UpdatePage(int page_number, Pages new_page)
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
        }
    }
}

       