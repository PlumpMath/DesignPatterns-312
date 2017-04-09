using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win.DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsze pobranie");
            Singleton.Singleton.Instance().AddNotification("test");

            Console.WriteLine("Drugie pobranie");
            Singleton.Singleton.Instance().AddNotification("test1");


            Console.ReadLine();
        }
    }
}
