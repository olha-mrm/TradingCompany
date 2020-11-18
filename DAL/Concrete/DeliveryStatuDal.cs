using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DTO;

namespace DAL.Concrete
{
    public class DeliveryStatuDal : IDeliveryStatuDal
    {
        private string connectionString;

        public DeliveryStatuDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetStatusNameById(short id)
        {
            string statusName = "No such status";
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();

                comm.CommandText = $"select * from DeliveryStatus where DeliveryStatusID = {id}";
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    statusName = reader["DeliveryStatusID"].ToString();
                }

            }
            return statusName;

        }
        public List<DeliveryStatuDTO> GetAllStatuses()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from DeliveryStatus";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<DeliveryStatuDTO> statuses = new List<DeliveryStatuDTO>();
                while (reader.Read())
                {
                    statuses.Add(new DeliveryStatuDTO
                    {
                        DeliveryStatusID = (short)reader["DeliveryStatusID"],
                        Status = reader["Status"].ToString()
                    }); ;
                }
                return statuses;
            }

        }
    }
}
