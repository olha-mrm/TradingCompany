using AutoMapper;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                entities.Users.Add(u);
                entities.SaveChanges();
                return _mapper.Map<UserDTO>(u);
            }
        }
    }
}
