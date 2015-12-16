using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = new char[10];
            var random = new Random();
            for(var i = 0; i < 10; i++)
            {
                password[i] = (char)('a' + random.Next(0,26)); 
            }
            var password = new string(password);
            Console.WriteLine(password);
        }
    }
}
