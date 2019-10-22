using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrabotka_isklucheniy
{
    class Program
    {
        static void Main(string[] args)
        {
            //try catch finally
            int[] nums = new int[4]; //3
            
            try
            {
                
                Console.WriteLine("Введите строку");
                string message = Console.ReadLine();
                if(message.Length>6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
                Console.WriteLine("End of try block");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Errors: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Errors: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errors: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.ReadKey();
        }
    }
}
