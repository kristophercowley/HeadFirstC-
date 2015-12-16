using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            var me = "Kristopher";
            for(var i = 0; i < me.Length; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
