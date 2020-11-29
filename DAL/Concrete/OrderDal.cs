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

        public List<OrderDTO> GetOrdersByUserId(long customerID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = $"select * from Orders where CustomerID = {customerID}";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<OrderDTO> myOrders = new List<OrderDTO>();
                while (reader.Read())
                {
                    myOrders.Add(new OrderDTO
                    
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
                return myOrders;
            }
        }

        public OrderDTO CreateOrder(OrderDTO order)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {                
                comm.CommandText = "INSERT into Orders (Date, CustomerID, StatusID, Comments, LastUpdate, LastStaffUpdated) output INSERTED.MainOrderID values (@date, @customerID, @statusID, @comments, @lastUpdate, @lastStaffUpdated)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@date", order.Date);
                comm.Parameters.AddWithValue("@customerID", order.CustomerID);
                comm.Parameters.AddWithValue("@statusID", order.StatusID);
                comm.Parameters.AddWithValue("@comments", order.Comments);
                comm.Parameters.AddWithValue("@lastUpdate", order.LastUpdate);
                comm.Parameters.AddWithValue("@lastStaffUpdated", order.LastStaffUpdated);
                conn.Open();

                order.MainOrderID = Convert.ToInt64(comm.ExecuteScalar());
                return order;
                  
            }
        }

        public OrderDTO UpdateOrder(OrderDTO order)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "UPDATE Orders set  Date = @date, " +
                    "CustomerID = @customerID, " +
                    "StatusID = @statusID, " +
                    "Comments = @comments, " +
                    "LastUpdate = @lastUpdate," +
                    "LastStaffUpdated = @lastStaffUpdated";
                
                comm.Parameters.Clear();

                comm.Parameters.AddWithValue("@date", order.Date);
                comm.Parameters.AddWithValue("@customerID", order.CustomerID);
                comm.Parameters.AddWithValue("@statusID", order.StatusID);
                comm.Parameters.AddWithValue("@comments", order.Comments);
                comm.Parameters.AddWithValue("@lastUpdate", order.LastUpdate);
                comm.Parameters.AddWithValue("@lastStaffUpdated", order.LastStaffUpdated);
                conn.Open();

                order.MainOrderID = Convert.ToInt64(comm.ExecuteScalar());
                return order;
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
        //        
        //    }
        //}
    }
}