using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercises2._1
{
    class Program
    {
       /* static void Main(string[] args)
        {
            // HowMany();
            //Class1.Ask();
            // Factorial.Factor();
            //RandomGuess.Guess();
            Series.Nums();
        }*/

        public static void HowMany()
        {
            var count = 0;
            for(var i = 0; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
