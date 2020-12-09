using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DALEF.Concrete;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly UserDalEf _userDal;

        public AuthManager(UserDalEf userDal)
        {
            _userDal = userDal;
        }
        public bool Login(string username, string password)
        {
            return _userDal.Login(username, password);
        }
        public long GetUserId(string username)
        {
            return _userDal.GetUserId(username);
        }
        //public int GetAccessLevel(string username)
        //{
        //    return _userDal.GetAccessLevel(username);
        //}
        public UserDTO GetUserByUsername(string username)
        {
            long id = GetUserId(username);
            return _userDal.GetUserById(id);
        }
    }
}
