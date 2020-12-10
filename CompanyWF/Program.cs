using CompanyWF.AppSettings;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using AutoMapper;
using Unity;
using BusinessLogic.Concrete;
using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DALEF.Concrete;
using DTO;

namespace CompanyWF
{
    static class Program
    {
        public static AppDataManager SettingsManager;
        public static UnityContainer Container;
        public static UserDTO User_here;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SettingsManager = new AppDataManager();
            LoginForm lf = Container.Resolve<LoginForm>();
            
            if (lf.ShowDialog() == DialogResult.OK)
            {
                User_here = lf.GetUser();
                Application.Run(Container.Resolve<MainForm>());
            }
            else
            {
                Application.Exit();
            }
        }

        private static void ConfigureUnity()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddMaps(typeof(UserDalEf).Assembly);
                });

            Container = new UnityContainer();
            Container.RegisterInstance<IMapper>(config.CreateMapper());
            Container.RegisterType<IUserDal, UserDalEf>()
                     .RegisterType<IOrderDal, OrderDalEf>()
                     .RegisterType<IOrdersRefDal, OrdersRefDalEf>()
                     .RegisterType<IDeliveryStatuDal, DeliveryStatuDalEf>()
                     .RegisterType<IItemDal, ItemDalEf>()
                     .RegisterType<IAuthManager, AuthManager>()
                     .RegisterType<IOrdersManager, OrdersManager>();
        }
    }
}
// admin -> letmein
// test -> hello
// martha -> drWho
//
//witcher -> check2
//triss -> awesome
//WinFtest -> qwerty123
//ciri -> zirael
// jsmith -> 12345jkl