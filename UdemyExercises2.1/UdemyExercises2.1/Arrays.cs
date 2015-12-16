using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UdemyExercises2._1
{
    class Arrays
    {
         static void Main()
        {
            var numbers = new [] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("Length: " + numbers.Length);
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);
            Array.Clear(numbers, 0, 2);                                 
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            //copy
            var another = new int[3];
            Array.Copy(numbers, another, 3);  
            foreach (var n in another)
            {
                Console.WriteLine(n + "\n newLine \n nextLine \n lastLine");
            }
            Console.ReadLine();
            

        }
    }
}
