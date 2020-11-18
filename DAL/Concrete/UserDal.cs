using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Concrete
{
    public class UserDal : IUserDal
    {
        private string connectionString;

        public UserDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<UserDTO> GetAllUsers()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "select * from Users";
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                List<UserDTO> users = new List<UserDTO>();
                while(reader.Read())
                {
                    users.Add(new UserDTO
                    {
                        UserID = (long)reader["UserId"],
                        FullName = reader["FullName"].ToString(),
                        Password = (byte[])reader["Password"],
                        Position = reader["Position"].ToString(),
                        AccessLevel =(int)reader["AccessLevel"],
                        Username = reader["Username"].ToString(),
                        Salt = reader["Salt"].ToString()
                    });
                }
                return users;
            }
        }
        public UserDTO GetUserById(long id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                conn.Open();
                UserDTO user = new UserDTO();
                comm.CommandText = $"select * from Users where UserID = {id}";
                SqlDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    user = new UserDTO
                    {
                        UserID = (long)reader["UserId"],
                        FullName = reader["FullName"].ToString(),
                        Password = (byte[])reader["Password"],
                        Position = reader["Position"].ToString(),
                        AccessLevel = (int)reader["AccessLevel"],
                        Username = reader["Username"].ToString(),
                        Salt = reader["Salt"].ToString()
                    };
                }
                return user;
            }
        }

        public UserDTO CreateUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "insert into Users (FullName, Password, Position, AccessLevel, Username, Salt)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@FullName", user.FullName);
                comm.Parameters.AddWithValue("@Password", user.Password);
                comm.Parameters.AddWithValue("@Position", user.Position);
                comm.Parameters.AddWithValue("@AccessLevel", user.AccessLevel);
                comm.Parameters.AddWithValue("@Username", user.Username);
                comm.Parameters.AddWithValue("@Salt", user.Salt);

                conn.Open();
                user.UserID = Convert.ToInt64(comm.ExecuteScalar());
                return user;
            }
        }
    }
}
