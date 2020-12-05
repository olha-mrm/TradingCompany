using AutoMapper;
using DTO;
using DALEF.Concrete;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TradingCompany.Menu;

namespace TradingCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.Start();
        }
    }
}