using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class SingletonObject
    {
        private static readonly SingletonObject instance = new SingletonObject();

        private SingletonObject() {}

        public static SingletonObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello from Singleton Pattern");
        }
    }
}
