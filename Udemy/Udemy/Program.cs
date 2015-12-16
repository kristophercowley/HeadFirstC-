using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("its afternoon");
            }
            else
            {
                Console.WriteLine("its evening");
               
            }
        }
    }
}
