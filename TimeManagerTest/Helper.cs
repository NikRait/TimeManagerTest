using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagerTest
{
    public static class Helper
    {
        public static int MyTryParse(this int result, string input)
        {
            do
            {
                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Enter correct value");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            } while (true);
            return result;
        }
        public static int MyTryParse(this int result, string input, int maxValue)
        {
            do
            {
                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Enter correct value");

                }
                else
                {
                    if (result > maxValue)
                    {
                        Console.WriteLine("Enter correct value");
                    }
                    else
                        break;
                }
                input = Console.ReadLine();
            } while (true);
            return result;
        }
        public static int MyTryParse(this int result, string input, int minValue, int maxValue)
        {
            do
            {
                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Enter correct value");

                }
                else
                {
                    if (result < minValue || result > maxValue)
                    {
                        Console.WriteLine("Enter correct value");
                    }
                    else
                        break;
                }
                input = Console.ReadLine();
            } while (true);
            return result;
        }
    }
}
