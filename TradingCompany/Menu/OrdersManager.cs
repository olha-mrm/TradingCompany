using DAL.Interfaces;
using DTO;
using AutoMapper;
using DALEF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.Menu
{
    public class OrdersManager
    {
        private IOrderDal dalorder;
        //private IOrdersRefDal dalref;
        
        public OrdersManager(IOrderDal dalorder)
        {
            this.dalorder = dalorder;
            //this.dalref = dalref;
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
                            createOrder();
                            printOptions();
                            break;
                        case 2:
                            updateOrder();
                            printOptions();
                            break;
                        case 3:
                            printAllOrders();
                            printOptions();
                            break;
                        case 4:
                            addItems();
                            printOptions();
                            break;
                        case 5:
                            updateItemInOrder();
                            printOptions();
                            break;
                        case 6:
                            deleteItemsFromOrder();
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

        private void createOrder()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tCreating New Order\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input ID of the customer: ");
            long _customerID = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Input Status ID for order: ");
            short _status = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input Comments for the order: ");
            string _comments = Console.ReadLine();

            OrderDTO myOrder = new OrderDTO
            {
                Date = DateTime.UtcNow,
                CustomerID = _customerID,
                StatusID = _status,
                Comments = _comments,
                LastUpdate = DateTime.UtcNow,
                LastStaffUpdated = 1 //ID of user admin
            };
            try 
            { 
                myOrder = dalorder.CreateOrder(myOrder);
                Console.WriteLine($"New OrderID is {myOrder.MainOrderID}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Data inputted incorrectly. Order failed.");
            }            
        }
        
        private void updateOrder()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tUpdating Order\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input OrderID: ");
            long id = Convert.ToInt64(Console.ReadLine());

            OrderDTO myOrder = dalorder.GetOrderByID(id);

            if (myOrder is null) //check if such order exists
            {
                Console.WriteLine("Invalid input! No such order in database.\n");
                return;
            }

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("~ Updating Order:\n\tID: {0}\tCustomer: {1} {2} \tStatus: {3} \n\tComments: {4}\n",
                    myOrder.MainOrderID, myOrder.CustomerID, getFullNameById(myOrder.CustomerID), getStatusById(myOrder.StatusID), myOrder.Comments);
                Console.WriteLine("Items in order: ");
                printItemsInOrder(myOrder.MainOrderID);

                Console.WriteLine("\nChoose an option:" +
                    "\n\t1. Change customer" +
                    "\n\t2. Chnage status" +
                    "\n\t3. Change comments" +
                    "\n\t0. Exit");
                try
                {
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 0) flag = false;
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("Input new CustomerID: ");
                            myOrder.CustomerID = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Input new StatusID: ");
                            myOrder.StatusID = Convert.ToInt16(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Input comment: ");
                            myOrder.Comments = Console.ReadLine();
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
                myOrder.LastUpdate = DateTime.UtcNow;
                myOrder.LastStaffUpdated = 1; //id of admin
                try
                {
                    myOrder = dalorder.UpdateOrder(myOrder);
                    Console.WriteLine($"Updated Item ID: {myOrder.MainOrderID}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Data inputted incorrectly. Order update failed.");
                }
            }
        }
        
        private void addItems() //creates rows in table OrdersRef
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tAdding Items to an Order\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input OrderID: ");
            long id = Convert.ToInt64(Console.ReadLine());

            OrderDTO myOrder = dalorder.GetOrderByID(id);

            if (myOrder is null) //check if such order exists
            {
                Console.WriteLine("Invalid input! No such order in database.\n");
                return;
            }
            ItemsManager MyItems = new ItemsManager(new ItemDalEf(SetupMapper()));
            MyItems.printAll();

            Console.WriteLine("Input 1 to add an item or 0 to exit");

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
                            Console.WriteLine("Input ID of the Item you want to add: ");
                            long _itemID = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("How many items you wish to add?");
                            int _amount = Convert.ToInt32(Console.ReadLine());
                              

                            OrdersRefDTO _myOrder = new OrdersRefDTO
                            {
                                refOrderID = myOrder.MainOrderID,
                                refItemID = _itemID,
                                amount = _amount
                            };
                            IMapper mapper = SetupMapper();
                            IOrdersRefDal dalref = new OrdersRefDalEf(mapper);
                            _myOrder = dalref.CreateOrderRef(_myOrder);
                            Console.WriteLine($"~ Success! ~\nNew Item with ID {_myOrder.refItemID} added to order {_myOrder.refOrderID}");
                            Console.WriteLine("\nInput 1 to add an item or 0 to exit");
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
                    Console.WriteLine("\nSomething went wrong... Try again, or input 0 to exit.");
                }
            }
        }
        
        private void updateItemInOrder()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tAdding Items to an Order\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input OrderID: ");
            long id = Convert.ToInt64(Console.ReadLine());

            OrderDTO myOrder = dalorder.GetOrderByID(id);

            if (myOrder is null) //check if such order exists
            {
                Console.WriteLine("\n~~~ ERROR ~~~~\t No such order in database.\n");
                return;
            }
            IMapper mapper = SetupMapper();
            IOrdersRefDal dalref = new OrdersRefDalEf(mapper);
            List<OrdersRefDTO> myList = dalref.GetItemsInOrder(id);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine($"~ Updating Order: {myOrder.MainOrderID}");
                foreach (var i in myList)
                {
                    Console.WriteLine("Amount: {0}, ItemID: {1}", i.amount, i.refItemID);
                }
                Console.WriteLine("Names of Items in order: ");
                printItemsInOrder(myOrder.MainOrderID);

                Console.WriteLine("\nChoose an option:" +
                    "\n\t1. Change number of items" +
                    "\n\t0. Exit");
                try
                {
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 0) flag = false;
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("Input ID of Item you wish to change number of: ");
                            long _itemID = Convert.ToInt64(Console.ReadLine());
                            OrdersRefDTO currentItem = myList.Find(o => o.refItemID == _itemID);

                            if (currentItem is null)
                            {
                                Console.WriteLine("\n~~~ ERROR ~~~~\tNo such item in order!\n\n");
                                break;
                            }

                            Console.WriteLine("Input new number of items: ");
                            int am = Convert.ToInt32(Console.ReadLine());
                            currentItem.amount = am; 

                            currentItem = dalref.UpdateOrderRef(currentItem);
                            Console.WriteLine($"Updated number of items: {currentItem.amount}");
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
            }
        }

        private void deleteItemsFromOrder()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tDeleting Items from Order\t ~*~ ~*~ ~*~\n");
            Console.WriteLine("Input OrderID: ");
            long id = Convert.ToInt64(Console.ReadLine());

            OrderDTO myOrder = dalorder.GetOrderByID(id);

            if (myOrder is null) //check if such order exists
            {
                Console.WriteLine("\n~~~ ERROR ~~~~\t No such order in database.\n");
                return;
            }           

            IMapper mapper = SetupMapper();
            IOrdersRefDal dalref = new OrdersRefDalEf(mapper);
            List<OrdersRefDTO> myList = dalref.GetItemsInOrder(id); //get all items in this order
            foreach (var i in myList)
            {
                Console.WriteLine("Amount: {0}, ItemID: {1}", i.amount, i.refItemID);
            }
            Console.WriteLine("Names of Items in order: ");
            printItemsInOrder(myOrder.MainOrderID); //print those items

            Console.WriteLine("Input ID of Item you want to delete: ");
            long _itemID = Convert.ToInt64(Console.ReadLine());
            OrdersRefDTO currentItem = myList.Find(o => o.refItemID == _itemID);
            if (currentItem is null)
            {
                Console.WriteLine("\n~~~ ERROR ~~~~\tNo such item in order!\n\n");
                return;
            }
            dalref.DeleteOrderRef(id, _itemID);
        }
        private void printAllOrders()
        {
            Console.WriteLine("\t~*~ ~*~ ~*~ \tList of Orders with Items\t ~*~ ~*~ ~*~\n");

            foreach (var o in dalorder.GetAllOrders())
            {
                Console.WriteLine("ID: {0}\t| Customer: {1}\t | Status: {2}\t | Date: {3}\t\n " +
                    "Comments: {4}\nLast Update at {5} \tby {6}",
                    o.MainOrderID, getFullNameById(o.CustomerID), getStatusById(o.StatusID), o.Date,
                    o.Comments, o.LastUpdate, getFullNameById(o.LastStaffUpdated.GetValueOrDefault(0)));
                printItemsInOrder(o.MainOrderID);
            }
        }
        
        private void printOptions()
        {
            Console.WriteLine("==========================\t~Orders Menu Options~\t==========================\n");
            Console.WriteLine("\t1. Create new Order");
            Console.WriteLine("\t2. Update Order details");
            Console.WriteLine("\t3. Get all Orders");
            Console.WriteLine("\t4. Add Items to Order");
            Console.WriteLine("\t5. Update Number of Items in Order");
            Console.WriteLine("\t6. Delete Items from Order");
            Console.WriteLine("\t0. Exit.");
        }

        private string getFullNameById(long id)
        {
            IMapper mapper = SetupMapper();
            IUserDal user = new UserDalEf(mapper);
            if (id == 0)
                return "no";
            return user.GetUserById(id).FullName;
        }
        private string getStatusById(short id)
        {
            IMapper mapper = SetupMapper();
            IDeliveryStatuDal delst = new DeliveryStatuDalEf(mapper);
            return delst.GetStatusNameById(id);
        }
        private void printItemsInOrder(long id)
        {
            IMapper mapper = SetupMapper();
            IItemDal item = new ItemDalEf(mapper);
            IOrdersRefDal dalref = new OrdersRefDalEf(mapper);
            foreach (var i in dalref.GetItemsInOrder(id))
            {
                Console.WriteLine("amount: {0}\t {1}",
                     i.amount, item.GetItemById(i.refItemID).Title);
            }
            Console.WriteLine();
        }
        private static IMapper SetupMapper()
        {
            MapperConfiguration conf = new MapperConfiguration(
                    cfg => cfg.AddMaps(typeof(ItemDalEf).Assembly)
                );
            return conf.CreateMapper();
        }
    }
}