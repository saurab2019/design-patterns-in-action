using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        public int connectionPoolSize { get; set; }
        //If we know singleton is always used by the application
        //public static Singleton instance = new Singleton();
        //public static Singleton instance;
        //private static readonly object lockObj = new object();

        //public static Singleton getInstance()
        //{
        //    //Second way
        //    if (instance == null)
        //    {
        //        lock (lockObj)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Singleton();
        //            }
        //        }
        //    }
        //    return instance;
        //}

        //Third way 
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => instance.Value;

        private Singleton() 
        {
            connectionPoolSize = 10;
            Console.WriteLine("Singleton class created");
        }
    }
}
