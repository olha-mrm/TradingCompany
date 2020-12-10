using AutoMapper;
using BusinessLogic.Concrete;
using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DALEF.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CompanyWPF;
using Unity;

namespace CompanyWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IUnityContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            base.OnStartup(e);
            RegisterUnity();
            RegisterAutoMapper();

            Login lf = Container.Resolve<Login>();
            bool result = lf.ShowDialog() ?? false;
            if (result)
            {
                MainWindow ol = Container.Resolve<MainWindow>();
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = ol;
                ol.ShowDialog();
            }
            else
            {
                Current.Shutdown();
            }
        }
        private void RegisterAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddMaps(typeof(OrderDalEf).Assembly);
                });

            Container.RegisterInstance(config.CreateMapper());
        }


        private void RegisterUnity()
        {
            Container = new UnityContainer();

            Container.RegisterType<IDeliveryStatuDal, DeliveryStatuDalEf>()
                     .RegisterType<IItemDal, ItemDalEf>()
                     .RegisterType<IOrdersRefDal, OrdersRefDalEf>()
                     .RegisterType<IOrderDal, OrderDalEf>()
                     .RegisterType<IUserDal, UserDalEf>()
                     .RegisterType<IOrdersManager, OrdersManager>()
                     .RegisterType<IAuthManager, AuthManager>();
        }
    }
}
