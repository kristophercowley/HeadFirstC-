using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var max1 = Console.ReadLine();
            var num1 = Int32.Parse(max1);
            Console.WriteLine("Enter another number");
            var max2 = Console.ReadLine();
            var num2 = Int32.Parse(max2);
            if(num1 > num2)
            {
                Console.WriteLine(num1 + " is max");
                Console.ReadLine();
            }else
            {
                Console.WriteLine(num2 + " is max");
                Console.ReadLine();
            }




        }
    }
}
