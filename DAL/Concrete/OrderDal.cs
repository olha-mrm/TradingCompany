using System;
using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class OrderDal : Interfaces.IOrderDal
    {
        private string connectionString;

        public OrderDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<OrderDTO> GetAllOrders()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from Orders";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<OrderDTO> orders = new List<OrderDTO>();
                while (reader.Read())
                {
                    orders.Add(new OrderDTO
                    {
                        MainOrderID = (long)reader["MainOrderID"],
                        Date = (DateTime)reader["Date"],
                        CustomerID = (long)reader["CustomerID"],
                        StatusID = (short)reader["StatusID"],
                        Comments = reader["Comments"].ToString(),
                        LastUpdate = (DateTime)reader["LastUpdate"],
                        LastStaffUpdated = (long)reader["LastStaffUpdated"]
                    });                    
                }
                return orders;
            }
        }
        public OrderDTO GetOrderByID(long orderID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = $"select * from Orders where mainOrderId = {orderID}";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                OrderDTO myOrder = new OrderDTO();
                while (reader.Read())
                {
                    myOrder = new OrderDTO
                    {
                        MainOrderID = (long)reader["MainOrderID"],
                        Date = (DateTime)reader["Date"],
                        CustomerID = (long)reader["CustomerID"],
                        StatusID = (short)reader["StatusID"],
                        Comments = reader["Comments"].ToString(),
                        LastUpdate = (DateTime)reader["LastUpdate"],
                        LastStaffUpdated = (long)reader["LastStaffUpdated"]
                    };
                }
                return myOrder;
            }
        }

        // TO DO !!!

        //public OrderDTO SetOrderStatus(OrderDTO order, short new_status)
        //{
        //    using (SqlConnection conn = new SqlConnection(this.connectionString))
        //    using (SqlCommand comm = conn.CreateCommand())
        //    {
        //        comm.CommandText = $"UPDATE Orders SET StatusID = {new_status} WHERE MainOrderID = {order.MainOrderID}";
        //        conn.Open();
        //        SqlDataReader reader = comm.ExecuteReader();
        //        //Console.WriteLine("Here done!");
        //    }
        //}
    }
}