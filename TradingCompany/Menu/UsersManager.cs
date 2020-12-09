using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace TradingCompany.Menu
{
    public class UsersManager
    {
        private IUserDal dal;
        public UsersManager(IUserDal dal)
        {
            this.dal = dal;
        }

        public void Menu()
        {
            printOptions();
            int step;
            bool flag = true;
            while (flag)
            {
                try
                {
                    step = Convert.ToInt32(Console.ReadLine());
                    switch (step)
                    {
                        case 1:
                            create();
                            printOptions();
                            break;
                        case 2:
                            update();
                            printOptions();
                            break;
                        case 3:
                            delete();
                            printOptions();
                            break;
                        case 4:
                            printAll();
                            printOptions();
                            break;
                        case 0:
                            flag = false;
                            break;
                        default:
                            throw new Exception("Invalid data inputted. Try again!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Try again, or input 0 to exit.");
                }
            }
        }
        private void create()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tCreating New User\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input Full Name: ");
            string _fullName = Console.ReadLine(); 
            Console.WriteLine("Input Password: ");

            string _inputtedPassword = Console.ReadLine();// do not save it
            string _salt = generateSalt();
            string toHash = _inputtedPassword + _salt;

            byte[] _password = new byte [toHash.Length];
            _password = dal.hash(_inputtedPassword, _salt); //save it to database
            //Console.WriteLine(Convert.ToBase64String(_password));

            Console.WriteLine("Input Username: ");
            string _username = Console.ReadLine();
            Console.WriteLine("Input Access level: ");
            int _accessLvl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Position: ");
            string _position = Console.ReadLine();
            
            UserDTO _user = new UserDTO
            {
                FullName = _fullName,
                Salt = _salt,
                Password = _password,
                Username = _username,
                AccessLevel = _accessLvl,
                Position = _position
            };
            //Console.WriteLine("here1");
            _user = dal.CreateUser(_user);
            Console.WriteLine("here\n\n");
            Console.WriteLine($"New UserID is {_user.UserID}");            
        }
        
        private string generateSalt()
        {           
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 12)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //private byte[] createHashedPassword(string inputString)//returns hashed password
        //{
        //    using (HashAlgorithm algorithm = SHA256.Create())
        //        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        //}

        //private byte[] hash(string password, string salt)
        //{
        //    var alg = SHA512.Create();
        //    return alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        //}
        private void update()
        {
            Console.WriteLine("\n\t~*~ ~*~ ~*~ \tUpdating User\t ~*~ ~*~ ~*~\n");

            Console.WriteLine("Input UserID: ");
            long id = Convert.ToInt64(Console.ReadLine());

            UserDTO u = dal.GetUserById(id);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("~ Updating User:\n\tID: {0}\n\tFullName: {1} \n\tPassword {2} \n\tSalt: {3} \n\tUsername: {4} \n\tPosition: {5}\n\tAccessLevel: {6}",
                    u.UserID, u.FullName, Convert.ToBase64String(u.Password), u.Salt, u.Username, u.Position, u.AccessLevel);
                Console.WriteLine("Choose an option:" +
                    "\n\t1. Change Full Name" +
                    "\n\t2. Change Password (and salt)" +
                    "\n\t3. Chnage Username" +
                    "\n\t4. Change Position" +
                    "\n\t5. Change AccessLevel" +
                    "\n\t0. Exit");
                try
                {
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 0) flag = false;
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("Input new Full Name: ");
                            string fullName = Console.ReadLine();
                            u.FullName = fullName;
                            break;
                        case 2: /////////
                            Console.WriteLine("Input new Password: ");
                            string _inputtedPassword = Console.ReadLine();
                            string _salt = generateSalt();

                            Console.WriteLine();
                            u.Salt = _salt;
                            u.Password = new byte[64];                           

                            u.Password = dal.hash (_inputtedPassword, _salt);                            
                            
                            //u = dal.UpdateUser(u);                           
                            
                            break;
                        case 3:
                            Console.WriteLine("Input new Username: ");
                            string username = Console.ReadLine();
                            u.Username = username;
                            break;
                        case 4:
                            Console.WriteLine("Input new Position: ");
                            string position = Console.ReadLine();
                            u.Position = position;
                            break;
                        case 5:
                            Console.WriteLine("Input new AccessLevel: ");
                            int acslvl = Convert.ToInt32(Console.ReadLine());
                            u.AccessLevel = acslvl;
                            break;
                        case 0:
                            flag = false;
                            break;
                        default:
                            throw new Exception("Invalid input.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Try again, or input 0 to exit.");
                }

                u = dal.UpdateUser(u);
                Console.WriteLine($"Updated Item ID: {u.UserID}");
                printAll();
            }
        }

        private void delete()
        {
            Console.WriteLine("\n\t~*~ ~*~ ~*~ \tDeleting User\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input UserID: ");
            long id = Convert.ToInt64(Console.ReadLine());
            dal.DeleteUser(id);
            printAll();
        }
        private void printAll()
        {
            Console.WriteLine("\n\t~*~ ~*~ ~*~ \tList of Users\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("ID: \tFullName \tUsername \tPosition \tAccessLevel \tSalt \t\tPassword ");
            foreach (var u in dal.GetAllUsers())
            {
                Console.WriteLine("{0} \t{1} \t{2}\t \t{3} \t{4} \t\t{5} \t{6}",
                    u.UserID, u.FullName, u.Username,
                    u.Position, u.AccessLevel,
                    u.Salt, Convert.ToBase64String(u.Password));
            }
            Console.WriteLine("\n\n");
        }
        private void printOptions()
        {
            Console.WriteLine("==========================\t~User Menu Options~\t==========================\n");
            Console.WriteLine("\t1. Create new user");
            Console.WriteLine("\t2. Update user");
            Console.WriteLine("\t3. Delete user");
            Console.WriteLine("\t4. Get all users");
            Console.WriteLine("\t0. Exit.");
        }
    }
}
