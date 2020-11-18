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

    }
}
