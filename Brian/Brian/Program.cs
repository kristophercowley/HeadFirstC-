using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brian
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Program.Volume();
        }
        
            

            public static void Volume()
        {
            Console.WriteLine("enter height");
               var height = Console.ReadLine();
            var heightNum = int.Parse(height);
            Console.WriteLine("enter width");
            var width = Console.ReadLine();
            var widthNum = int.Parse(width);
            Console.WriteLine("enter base");
            var bottom = Console.ReadLine();
            var bottomNum = int.Parse(bottom);
            Console.WriteLine("The prism is" + heightNum * widthNum * bottomNum);
            Console.ReadLine();

        }
        }
    }

