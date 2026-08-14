using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    internal class categorieslist
    {

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";


        public int ID {  get; set; }
        public string categories { get; set; }
        public string status { get; set; }
        public string datecreated { get; set; }

        public List<categorieslist> categoriesListData()
        {
            List<categorieslist> listdata = new List<categorieslist>();

            using(SqlConnection connect = new SqlConnection(connection)) 
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                {
                SqlDataReader reader = cmd.ExecuteReader() ;

                    while (reader.Read()) 
                    {
                        categorieslist cData = new categorieslist();
                        cData.ID = (int)reader["id"];
                        cData.categories = reader["category"].ToString();
                        cData.status = reader["status"].ToString();
                        cData.datecreated = ((DateTime)reader["date_created"]).ToString("dd-MM-yyyy");

                        listdata.Add(cData);
                    }
                
                }
            }

            return listdata;
        }
    }
}
