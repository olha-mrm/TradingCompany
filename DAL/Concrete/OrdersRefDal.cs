﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL.Concrete
{
    public class OrdersRefDal : Interfaces.IOrdersRefDal
    {
        private string connectionString;

        public OrdersRefDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<OrdersRefDTO> GetItemsInOrder(long orderID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = $"select * from OrdersRef where refOrderID = {orderID}";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<OrdersRefDTO> ordersRef = new List<OrdersRefDTO>();
                while (reader.Read())
                {
                    ordersRef.Add(new OrdersRefDTO
                    {
                        refOrderID = (long)reader["refOrderID"],
                        refItemID = (long)reader["refItemID"],
                        amount = (int)reader["amount"]
                    });

                }
                return ordersRef;
            }
        }
        public List<OrdersRefDTO> GetOrdersByItem(long itemID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = $"select * from OrdersRef where refOrderID = {itemID}";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<OrdersRefDTO> ordersRef = new List<OrdersRefDTO>();
                while (reader.Read())
                {
                    ordersRef.Add(new OrdersRefDTO
                    {
                        refOrderID = (long)reader["refOrderID"],
                        refItemID = (long)reader["refItemID"],
                        amount = (int)reader["amount"]
                    });

                }
                return ordersRef;
            }
        }
        public OrdersRefDTO CreateOrderRef(OrdersRefDTO orderRef)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "INSERT into OrdersRef (refOrderID, refItemID, amount) values (@refOrderID, @refItemID, @amount)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@refOrderID", orderRef.refOrderID);
                comm.Parameters.AddWithValue("@refItemID", orderRef.refItemID);
                comm.Parameters.AddWithValue("@amount", orderRef.amount);

                conn.Open();
                return orderRef;
            }
        }
        public OrdersRefDTO UpdateOrderRef(OrdersRefDTO orderRef)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "UPDATE OrdersRef set amount = @amount";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@amount", orderRef.amount);
                conn.Open();
                //
                orderRef.refOrderID = Convert.ToInt64(comm.ExecuteScalar());
                return orderRef;
            }
        }

        public void DeleteOrderRef(long orderID, long itemID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "DELETE from OrdersRef WHERE refOrderID = @orderID and refItemID = @itemID";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@orderID", orderID);
                comm.Parameters.AddWithValue("@itemID", itemID);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }
    }
}