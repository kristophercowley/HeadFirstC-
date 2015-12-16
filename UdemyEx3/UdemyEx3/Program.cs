using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of your rectangle");
            var width = Console.ReadLine();
            var widthNum = int.Parse(width);
            Console.WriteLine("Enter the height of your rectangle");
            var height = Console.ReadLine();
            var heightNum = int.Parse(height);
            if(widthNum > heightNum)
            {
                Console.WriteLine("This is a landscape image");
                Console.ReadLine();
            }else
            {
                Console.WriteLine("This is a portrait image");
                Console.ReadLine();

            }
        }
    }
}
