using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 & 10");
            var input= Console.ReadLine();
            var number = Convert.ToInt32(input);
            if(number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
