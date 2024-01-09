using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementFinal
{
    class DataIssueBooks
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F01AA5A\\SQLEXPRESS;Initial Catalog=LibrarySystem;Persist Security Info=True;User ID=soulisack;Password=77477686");
        SqlCommand cmd;
        SqlDataReader dr;
        public int ID { set; get; }
        public string IssueID { set; get; }
        public string Name { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string DateIssue { set; get; }
        public string DateReturn { set; get; }
        public string Status { set; get; }
        //issuesBooks
        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                    cmd = new SqlCommand(selectData, conn);
                        dr = cmd.ExecuteReader();


                        while (dr.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = (int)dr["isID"];
                            dib.IssueID = dr["issue_id"].ToString();
                            dib.Name = dr["full_name"].ToString();
                            dib.Contact =dr["contact"].ToString();
                            dib.Email = dr["email"].ToString();
                            dib.BookTitle = dr["book_title"].ToString();
                            dib.Author = dr["author"].ToString();
                            dib.DateIssue = dr["issue_date"].ToString();
                            dib.DateReturn = dr["return_date"].ToString();
                            dib.Status = dr["status"].ToString();

                            listData.Add(dib);
                        }

                        dr.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }

            return listData;
        }
        //returnBooks
        public List<DataIssueBooks> ReturnIssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM issues WHERE status = 'Not Return' AND date_delete IS NULL";

                    SqlCommand cmd = new SqlCommand(selectData, conn);
                        dr = cmd.ExecuteReader();


                        while (dr.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = (int)dr["isID"];
                            dib.IssueID = dr["issue_id"].ToString();
                            dib.Name = dr["full_name"].ToString();
                            dib.Contact = dr["contact"].ToString();
                            dib.Email = dr["email"].ToString();
                            dib.BookTitle = dr["book_title"].ToString();
                            dib.Author = dr["author"].ToString();
                            dib.DateIssue = dr["issue_date"].ToString();
                            dib.DateReturn = dr["return_date"].ToString();
                            dib.Status = dr["status"].ToString();

                            listData.Add(dib);
                        }

                        dr.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }

            return listData;
        }
    }
}
