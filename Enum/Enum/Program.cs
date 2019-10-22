using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Days // int
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 3,
        Friday = 7,
        Saturday = 5,
        Sunday = 6

    }
    class Program
    {
        enum Operation
        {
            Add, //+
            Subtract, //-
            Multiply, //*
            Divide //(/)
        }
        static void ApplyOperation(double x, double y, Operation op)
        {
            double result = 0.0;
            switch(op)

            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            ApplyOperation(10, 15, Operation.Add); //25
            ApplyOperation(10, 15, Operation.Multiply); //150
            Console.ReadKey();
        }
    }
}
