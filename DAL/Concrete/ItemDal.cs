using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using DAL.Interfaces;

namespace DAL.Concrete
{
    public class ItemDal : IItemDal
    {
        private string connectionString;

        public ItemDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetNameByID(long id)
        {
            string ItemTitle = "NOTHING";
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                comm.CommandText = $"select * from Items where ItemId = {id}";
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ItemTitle = reader["Title"].ToString();
                }
            }
            return ItemTitle;
        }

        public ItemDTO GetItemById(long id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                ItemDTO item = new ItemDTO();
                comm.CommandText = $"select * from Items where UserID = {id}";
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    item = new ItemDTO
                    {
                        ItemID = (long)reader["ItemId"],
                        Title= reader["Title"].ToString(),
                        Price = (decimal)reader["Price"],
                        av_amount = (int)reader["av_amount"]
                    };
                }
                return item;
            }
        }

        public List<ItemDTO> GetAllItems()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "SELECT * from Items";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<ItemDTO> my_items = new List<ItemDTO>();

                while(reader.Read())
                {
                    my_items.Add(new ItemDTO
                    {
                        ItemID = (long)reader["ItemID"],
                        Title = reader["Title"].ToString(),
                        Price = (decimal)reader["Reader"],
                        av_amount = (int)reader["av_amount"]
                    });                   
                }
                return my_items;
            }
        }

        public ItemDTO UpdateItem(ItemDTO item)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "UPDATE Items set Title = @title, Price = @price, av_amount = @av_amount";
                comm.Parameters.Clear();
                              
                comm.Parameters.AddWithValue("@title", item.Title);
                comm.Parameters.AddWithValue("@price", item.Price);
                comm.Parameters.AddWithValue("@av_amount", item.av_amount);

                conn.Open();
                item.ItemID = Convert.ToInt64(comm.ExecuteScalar());
                return item;
            }
        }
        public ItemDTO CreateItem(ItemDTO item)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "INSERT into Items (Title, Price, av_amount) " +
                    "output INSERTED.UserID values (@title, @price, @av_amount)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("title", item.Title);
                comm.Parameters.AddWithValue("price", item.Price);
                comm.Parameters.AddWithValue("av_amount", item.av_amount);
                conn.Open();
                item.ItemID = Convert.ToInt64(comm.ExecuteScalar());
                return item;
            }
        }
        public void DeleteItem(long id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "DELETE from Items WHERE ItemID = @id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@id", id);
                conn.Open();

                comm.ExecuteNonQuery();
            }
        }

    }
}