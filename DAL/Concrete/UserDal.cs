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
                comm.CommandText = "insert into Users (FullName, Password, Position, AccessLevel, Username, Salt)" +
                    "output INSERTED.UserID values (@fullName, @password, @position, @accessLevel, @username, @salt)";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@fullName", user.FullName);
                comm.Parameters.AddWithValue("@password", user.Password);
                comm.Parameters.AddWithValue("@position", user.Position);
                comm.Parameters.AddWithValue("@accessLevel", user.AccessLevel);
                comm.Parameters.AddWithValue("@username", user.Username);
                comm.Parameters.AddWithValue("@salt", user.Salt);

                conn.Open();
                user.UserID = Convert.ToInt64(comm.ExecuteScalar());
                return user;
            }
        }

        public void DeleteUser(long id)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "DELETE from Users WHERE UserID = @id";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@id", id);
                conn.Open();
                comm.ExecuteNonQuery();
            }
        }

        public UserDTO UpdateUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = "UPDATE Users set FullName = @fullName, Password = @password, Position = @position, AccessLevel = @accessLevel, Username = @username, Salt = @salt";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@fullName", user.FullName);
                comm.Parameters.AddWithValue("@password", user.Password);
                comm.Parameters.AddWithValue("@position", user.Position);
                comm.Parameters.AddWithValue("@accessLevel", user.AccessLevel);
                comm.Parameters.AddWithValue("@username", user.Username);
                comm.Parameters.AddWithValue("@salt", user.Salt);

                conn.Open();
                user.UserID = Convert.ToInt64(comm.ExecuteScalar());
                return user;
            }

        }



        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
        public byte[] hash(string password, string salt)
        {
            throw new NotImplementedException();
        }
    }
}