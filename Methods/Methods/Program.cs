using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = Hello();
            int c = Sum();
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static int Sum()
        {
            int x = 8;
            int y = 3;
            int z = x * y;
            return z;
        }



        static string Hello()
        {
            return "Hello world!";
        }


        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
        
    }
}
