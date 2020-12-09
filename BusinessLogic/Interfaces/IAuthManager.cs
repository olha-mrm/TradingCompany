using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic.Interfaces
{
    public interface IAuthManager
    {
        bool Login(string username, string password);
        long GetUserId(string username);
        //int GetAccessLevel(string username);
        UserDTO GetUserByUsername(string username);
    }
}