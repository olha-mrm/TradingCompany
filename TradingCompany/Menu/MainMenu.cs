using AutoMapper;
using DALEF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Menu
{
    class MainMenu
    {
        public MainMenu() { }

        public void Start()
        {
            Console.WriteLine("==========================\t\t~START~\t\t==========================\n");

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
                            
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            
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
            Console.WriteLine("\t\t\t<MainMenu>");
            Console.WriteLine("\t1. Search for order");
            Console.WriteLine("\t2. Sort Orders");
            Console.WriteLine("\t3. Change delivery status for order");
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
