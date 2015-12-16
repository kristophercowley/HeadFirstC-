using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercises2._1
{
    class Series
    { 
       public static  void Nums()
        {
            Console.WriteLine("Enter a series of numbers seperated by a comma. Example- 1,2,3,4,5");
            var numEnter = Console.ReadLine();
            Console.WriteLine(numEnter);
            var highest = 0;
            foreach (var num in numEnter)
            {
                if(num > highest)
                {
                    highest = num;
                }
            }
            Console.WriteLine("The maximum is  " + (highest - 48));
            Console.ReadLine();
        }
    }
}
