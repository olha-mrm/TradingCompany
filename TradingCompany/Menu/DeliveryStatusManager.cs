using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Menu
{
    public class DeliveryStatusManager
    {
        private IDeliveryStatuDal dal;
        public DeliveryStatusManager(IDeliveryStatuDal dal)
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
        private void printAll()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tList of Delivery Statuses\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("ID\t Status");
            foreach (var i in dal.GetAllStatuses())
            {
                Console.WriteLine("{0}\t {1}",
                    i.DeliveryStatusID, i.Status);
            }
            Console.WriteLine("\n\n");
        }

        private void create()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tCreating New Delivery Status\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input new status name: ");
            string _status = Console.ReadLine();

            DeliveryStatuDTO myStatus = new DeliveryStatuDTO
            {
                Status = _status
            };
            myStatus = dal.CreateDeliveryStatus(myStatus);
            Console.WriteLine($"New DeliveryStatusID is {myStatus.DeliveryStatusID}");
            printAll();
        }
        private void update()
        {
            Console.WriteLine("Input DeliveryStatusID: ");
            short id = Convert.ToInt16(Console.ReadLine());

            DeliveryStatuDTO ds = dal.GetDelStatusById(id);


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("~ Updating Item:\n\tID: {0}\n\tStatus: {1} ",
                    ds.DeliveryStatusID, ds.Status);
                Console.WriteLine("Choose an option:" +
                    "\n\t1. Change status name" +
                    "\n\t0. Exit");
                try
                {
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 0) flag = false;
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("Input new Status name: ");
                            string st = Console.ReadLine();
                            ds.Status = st;
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
                ds = dal.UpdateDeliveryStatus(ds);
                Console.WriteLine("Updated Status:\n\tID: {0}\n\tStatus: {1} ", ds.DeliveryStatusID, ds.Status);
                printAll();
            }
        }
        private void delete()
        {
            Console.WriteLine("Input DeliveryStatusID: ");
            short id = Convert.ToInt16(Console.ReadLine());
            dal.DeleteDelStatus(id);
            printAll();
        }
        private void printOptions()
        {
            Console.WriteLine("==========================\t~Delivery Status Menu Options~\t==========================\n");
            Console.WriteLine("\t1. Create new Delivery Status");
            Console.WriteLine("\t2. Update Delivery Status");
            Console.WriteLine("\t3. Delete Delivery Status");
            Console.WriteLine("\t4. Get all Delivery Statuses");
            Console.WriteLine("\t0. Exit.");
        }
    }
}