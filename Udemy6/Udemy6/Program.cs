﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo: " + input);
            }
        }
        }
    }

