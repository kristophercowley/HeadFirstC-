using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercises2._1
{
    class Factorial
    {
        public static void Factor()
        {
            Console.WriteLine("Enter a number");
            var answer = int.Parse(Console.ReadLine());
            var minus1 = answer -1;
            var result = answer * minus1;
            for(var i = 0; minus1 > 1; i++)
            {
                minus1--;

                result *= minus1;

            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
