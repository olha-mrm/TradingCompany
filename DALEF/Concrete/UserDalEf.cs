using AutoMapper;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DALEF.Concrete
{
    public class UserDalEf : IUserDal
    {
        private readonly IMapper _mapper;

        public UserDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }
        public UserDTO GetUserById(long id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.UserID == id);
                return _mapper.Map<UserDTO>(user);
            }
        }
        
        public List<UserDTO> GetAllUsers()
        {
            using(var entities = new TradingCompanyEntities())
            {
                var users = entities.Users.ToList();
                return _mapper.Map<List<UserDTO>>(users);
            }
        }

        public UserDTO CreateUser(UserDTO user)
        {
            using (var entities = new TradingCompanyEntities())
            {
                User u = _mapper.Map<User>(user);                
                
                try
                {
                    entities.Users.Add(u);
                    entities.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                return _mapper.Map<UserDTO>(u);
            }
        }

        public void DeleteUser(long id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var u = entities.Users.SingleOrDefault(us => us.UserID == id);
                if (u == null) { return; }
                entities.Users.Remove(u);
                entities.SaveChanges();
            }
        }

        public UserDTO UpdateUser(UserDTO user)
        {
            using (var entities = new TradingCompanyEntities())
            {
                entities.Users.AddOrUpdate(_mapper.Map<User>(user));
                var _user = entities.Users.Single(u => u.UserID == user.UserID);
                entities.SaveChanges();
                return _mapper.Map<UserDTO>(_user);
            }
        }

        public bool Login(string username, string password)
        {
            using (var entities = new TradingCompanyEntities())
            {
                User user = entities.Users.SingleOrDefault(u => u.Username == username);
                if (user is null)
                {
                    return false;
                }
                //
                //1. Дістати пароль і сіль з бази
                //2. введений пароль + сіль -> хешую
                //3. порівняти отриманий хеш з хешом у базі 
                
                return user.Password.SequenceEqual(hash(password, user.Salt));
            }
        }
        //private byte[] createHashedPassword(string inputString)//returns hashed password
        //{
        //    using (HashAlgorithm algorithm = SHA256.Create())
        //        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        //}
        public byte[] hash(string password, string salt)
        {
            var alg = SHA512.Create();
            return alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        }

        public long GetUserId(string username)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.Username == username);
                if (user is null)
                    return 0;

                return user.UserID;
            }
        }
        public int GetAccessLevel(string username)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.Username == username);
                return user.AccessLevel != null ? user.AccessLevel.Value : 0;
            }
        }
    }
}
