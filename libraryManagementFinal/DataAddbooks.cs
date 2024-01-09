using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementFinal
{
    class DataAddbooks
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F01AA5A\\SQLEXPRESS;Initial Catalog=LibrarySystem;Persist Security Info=True;User ID=soulisack;Password=77477686");
        SqlDataReader reader;
        SqlCommand cmd;
        public int ID { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string Pulished { set; get; }
        public string image { set; get; }
        public string Status { set; get; }
        //Show Books is null
        public List<DataAddbooks> addBooksData()
        {
            List<DataAddbooks> listData = new List<DataAddbooks>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string selectData = "SELECT * FROM books WHERE date_delete IS NULL";

                         cmd = new SqlCommand(selectData, conn);
                         reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            DataAddbooks dab = new DataAddbooks();
                            dab.ID = (int)reader["bID"];
                            dab.BookTitle = reader["book_title"].ToString();
                            dab.Author = reader["author"].ToString();
                            dab.Pulished = reader["published_date"].ToString();
                            dab.image = reader["image"].ToString();
                            dab.Status = reader["status"].ToString();

                            listData.Add(dab);
                        }

                        reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error conenecting Database: " + ex);
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

