using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Addition(params int[] numbers)
        {
            int result = 0;
            for (int i=0; i < numbers.Length; i++)
            {

                result += numbers[i];
                

            }
            Console.WriteLine(result);
        }
        static void AdditionMas(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                result += numbers[i];


            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            AdditionMas(new int[] { 1, 2, 3, 4 });
            //AdditionMas(2, 3, 4, 5);
            //AdditionMas();
            Console.ReadKey();

        }

    }
}
