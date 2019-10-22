using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            var (name, age) = GetTuple(("Tom", 23), 12);

            Console.WriteLine(name);    
            Console.WriteLine(age);    
            Console.Read();
        }


        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
    }
}
