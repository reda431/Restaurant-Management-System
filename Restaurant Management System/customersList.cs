using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
     class customersList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reda\Documents\restaurantsystem.mdf;Integrated Security=True;Connect Timeout=30";

        public int id { set; get; }
        public string customerId { set; get; }
        public string productIds { set; get; }
        public string quantities { set; get; }
        public string prices { set; get; }
        public string totalPrice { set; get; }
        public string dateOrder { set; get; }

        public List<customersList> customerListData()
        {
            List<customersList> listData = new List<customersList>();

            using (SqlConnection connect = new SqlConnection(connection)) 
            {
                connect.Open();

                string selectData = "SELECT * FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectData , connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) 
                    { 
                        customersList cData = new customersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productIds = reader["productIds"].ToString();
                        cData.quantities = reader["quantities"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("dd-MM-yyyy");

                        listData.Add(cData);


                    }
                }
            
            }

                return listData;
        }
    }
}
