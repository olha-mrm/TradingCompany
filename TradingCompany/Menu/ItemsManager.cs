using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Menu
{
    public class ItemsManager
    {
        private IItemDal dal;
        public ItemsManager(IItemDal dal)
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
                            throw new Exception("You've inputed wrong data.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Try again, or input 0 to exit.");
                }
            }
        }

        public void printAll()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tList of Items\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("ID\t Item\t Price \t Available");
            foreach (var i in dal.GetAllItems())
            {
                Console.WriteLine("{0}\t {1} \t {2} \t {3}",
                    i.ItemID, i.Title, i.Price, i.av_amount);
            }
            Console.WriteLine("\n\n");
        }

        private void create()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tCreating New Item\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input Item Name: ");
            string _title = Console.ReadLine();
            Console.WriteLine("Input Price: ");
            decimal _price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Input number of available items:");
            int _available_amount = Convert.ToInt32(Console.ReadLine());

            ItemDTO myItem = new ItemDTO
            {
                Title = _title,
                Price = _price,
                av_amount = _available_amount
            };
            myItem = dal.CreateItem(myItem);
            Console.WriteLine($"New ItemID is {myItem.ItemID}");
            //list itmes
            printAll();
        }

        private void update()
        {
            Console.WriteLine("\n\t~*~ ~*~ ~*~ \tUpdating Item\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input ItemID: ");
            long id = Convert.ToInt64(Console.ReadLine());

            ItemDTO it = dal.GetItemById(id);
            
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("~ Updating Item:\n\tID: {0}\n\tName: {1} \n\tPrice {2} \n\tAvailable: {3}", 
                    it.ItemID, it.Title, it.Price, it.av_amount);
                Console.WriteLine("Choose an option:" +
                    "\n\t1. Change item name" +
                    "\n\t2. Chnage price" +
                    "\n\t3. Change number of available items" +
                    "\n\t0. Exit");
                try
                {
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 0) flag = false;
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("Input new item name: ");
                            string title = Console.ReadLine();
                            it.Title = title;
                            break;
                        case 2:
                            Console.WriteLine("Input new price: ");
                            decimal _price = Convert.ToDecimal(Console.ReadLine());
                            it.Price = _price;
                            break;
                        case 3:
                            Console.WriteLine("Input available number of items: ");
                            int av_num = Convert.ToInt32(Console.ReadLine());
                            it.av_amount = av_num;                            
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

                it = dal.UpdateItem(it);
                Console.WriteLine($"Updated Item ID: {it.ItemID}");
                printAll();
            }
        }

        private void delete()
        {
            Console.WriteLine("\n\t~*~ ~*~ ~*~ \tDeleting Item\t ~*~ ~*~ ~*~\n");

            Console.WriteLine("Input ItemID: ");
            long id = Convert.ToInt64(Console.ReadLine());
            dal.DeleteItem(id);
            printAll();
        }

        private void printOptions()
        {
            Console.WriteLine("==========================\t~Item Menu Options~\t==========================\n");
            Console.WriteLine("\t1. Create new item");
            Console.WriteLine("\t2. Update item");
            Console.WriteLine("\t3. Delete Item");
            Console.WriteLine("\t4. Get all itmes");
            Console.WriteLine("\t0. Exit.");
        }
    }
}
