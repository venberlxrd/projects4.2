using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekursiya
{
    class Program
    {
        // f(n) = n!; 5!=1*2*3*4*5=120
        // f(1) =1;
        // f(0) =1;
        // Factorial(5) = 5* Factorial(4)=5*4*Factorial(3)...=5*4*3*2*1*Factorial(0);


        static int Factorial(int k)
        {
            if (k == 0)
                return 1;
            else
                return k * Factorial(k - 1);
        }
        // F(n) = f(n-1) + f(n-2)
        // 1, 1, 2, 3, 5, 8, 13, 21...
        // F(0) = 0; F(1)=1;

        static int Fibonachi(int f)
        {
            if (f == 0)
                return 0;
            if (f == 1)
                return 1;
            else
                return Fibonachi(f-1)+Fibonachi(f-2);

        }


        static void Main(string[] args)
        {
            //int l = Factorial(5); // 120
            int l = Fibonachi(8); //21
            Console.WriteLine(l);
            //Console.WriteLine(Factorial(4)); // 24
            Console.WriteLine(Fibonachi(4)); //3
            //Console.WriteLine(Factorial(6)); // 720
            Console.WriteLine(Fibonachi(6)); //8
            Console.ReadKey();
        }
    }
}
