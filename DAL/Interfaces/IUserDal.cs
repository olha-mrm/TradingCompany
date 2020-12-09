using System;
using System.Collections.Generic;
using DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserDal
    {
        UserDTO GetUserById(long id);
        UserDTO CreateUser(UserDTO user);
        List<UserDTO> GetAllUsers();
        void DeleteUser(long id);
        UserDTO UpdateUser(UserDTO user);


        bool Login(string username, string password);
        byte[] hash(string password, string salt);
    }
}
