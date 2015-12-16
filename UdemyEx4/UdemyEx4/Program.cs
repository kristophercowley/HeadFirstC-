using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed");
            var speed = Console.ReadLine();
            var speedNum = int.Parse(speed);
            if(speedNum > 55)
            {
                var demerit = (speedNum - 55) / 5;
                Console.WriteLine("Thats " + demerit + " demerits fuck stick!");
                if(demerit > 12)
                {
                    Console.WriteLine("Your license is suspended");
                }
                Console.ReadLine();
            }else
            {
                Console.WriteLine("Ok");
                Console.ReadLine();

            }
        }
    }
}
