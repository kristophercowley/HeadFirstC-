using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class Testing
    {
        public static void Write()
        {
            var hi = "Hello World";
            Console.WriteLine(hi);


        }
        public static void Read()
        {
            Console.WriteLine("Enter your name please?");
            var result = Console.ReadLine();
            Console.WriteLine("Hello " + result + "! Are you over 18 years of Age?");
            var age = Console.ReadLine();

            if (age == "yes")
            {
                Console.WriteLine("Welcome Aboard");
            }
            else
            {
                Console.WriteLine("Sorry Sucker, your too young for this page");
            }

        }
        public static void Next()
        {
            Console.WriteLine("Please enter your nickname");
            var nickName = Console.ReadLine();
            if (nickName == "Dimebag")
            {
                Console.WriteLine("Youve unlocked a secret level Motherfucker! A New Level! Of Confidence! And Powerrrr!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("It would be a lot cooler if your nickname was dimebag!!!!!");
                Console.ReadLine();
            }
        }
        public static void Guess()
        {
            Console.WriteLine("Pick a number between 1 & 3");
            var num = Console.ReadLine();
            if (num != "2")
            {
                Console.WriteLine("I said between 1 and 3 dumbass");
            }
        }
        public static void Terry()
        {
            Console.WriteLine("Is your name Terry?");
            var name = Console.ReadLine();
            if (name == "Terry")
            {
                Console.WriteLine("Zizz");
                Console.WriteLine("ziiizzzz");
                Console.WriteLine("Teagz");
                
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Testing.Write();
                Testing.Read();
                Testing.Next();
                Testing.Guess();
                Testing.Terry();
                Testing.Write();
                Testing.Read();
                Testing.Next();
                Testing.Guess();
                
            }

        }

    }
}
