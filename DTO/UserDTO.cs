using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public long UserID { get; set; }
        public string FullName { get; set; }
        public byte[] Password { get; set; }
        public string Position { get; set; }
        public Nullable<int> AccessLevel { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
    }
}
