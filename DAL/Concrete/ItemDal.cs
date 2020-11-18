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

    }
}