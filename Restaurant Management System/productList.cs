using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    internal class productList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get;  }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string category { set; get; }
       // public string stock { set; get; }
        public string price { set; get; }
        public string status { set; get; }
        public string image { set; get; }
        public string date_created { set; get; }
        public string date_update { set; get; }

        public List<productList> productListData()
        {
            List<productList> listData = new List<productList>();

            using(SqlConnection Connect = new SqlConnection(connection))
            {
                Connect.Open();

                string selectData = "SELECT * FROM products ";


                using (SqlCommand cmd = new SqlCommand(selectData, Connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        productList pList = new productList();

                        pList.ID = (int)reader["ID"];
                        pList.ProductID = reader["productid"].ToString();
                        pList.ProductName = reader["productname"].ToString();
                        pList.category = reader["category"].ToString();
                       // pList.stock = reader["stock"].ToString();
                        pList.price = reader["price"].ToString();
                        pList.status = reader["status"].ToString();
                        pList.image = reader["image"].ToString();
                        pList.date_created = ((DateTime)reader["date_created"]).ToString("dd-MM-yyyy");
                        pList.date_update = reader["date_update"] == DBNull.Value ? null :((DateTime)reader["date_update"]).ToString("dd-MM-yyyy");

                        listData.Add(pList);

                    }
                }

            }

            return listData;
        }

    }
}
