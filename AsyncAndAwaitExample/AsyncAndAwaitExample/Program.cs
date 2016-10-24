using AsyncAndAwaitExample.Abstraction;
using AsyncAndAwaitExample.Implementation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AsyncAndAwaitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var unity = new UnityContainer();
            unity.RegisterType<IPrice, INStockPrice>();
            var instockprice = unity.Resolve<IPrice>();
            Console.WriteLine("Application Details using  UNITY " + instockprice.ToString());
            Console.ReadLine();
            
            
        }




    }
}
