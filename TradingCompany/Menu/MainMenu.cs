using AutoMapper;
using DALEF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Menu
{
    public class MainMenu
    {
        public MainMenu() { }

        public void Start()
        {
            Console.WriteLine("==========================\t ~START~ \t==========================\n");

            optionsMenu();

            int step;
            bool flag = true;
            IMapper mapper = SetupMapper();
            while (flag)
            {
                try
                {
                    step = Convert.ToInt32(Console.ReadLine());
                    switch (step)
                    {
                        case 1:
                            UsersManager UserM = new UsersManager(new UserDalEf(mapper));
                            UserM.Menu();
                            optionsMenu();
                            break;
                        case 2:
                            DeliveryStatusManager DStatusM = new DeliveryStatusManager(new DeliveryStatuDalEf(mapper));
                            DStatusM.Menu();
                            optionsMenu();
                            break;
                        case 3:
                            OrdersManager OrdersM = new OrdersManager(new OrderDalEf(mapper));
                            OrdersM.Menu();
                            optionsMenu();
                            break;                        
                        case 4:
                            ItemsManager ItemM = new ItemsManager(new ItemDalEf(mapper));
                            ItemM.Menu();
                            optionsMenu();
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

        private void optionsMenu()
        {
            Console.WriteLine("\t\t\t ~~~ Main Menu ~~~");
            Console.WriteLine("\t1. Work with Users table");
            Console.WriteLine("\t2. Work wtih DeliveryStatus Table");
            Console.WriteLine("\t3. Work with Orders and OrdersRef Tables");
            Console.WriteLine("\t4. Work with Items Table");
            Console.WriteLine("\t0. Exit.");
        }

        private static IMapper SetupMapper()
        {
            MapperConfiguration conf = new MapperConfiguration(
                    cfg => cfg.AddMaps(typeof(OrderDalEf).Assembly)
                );
            return conf.CreateMapper();
        }
    }
}
