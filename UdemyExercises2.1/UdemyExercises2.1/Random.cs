using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercises2._1
{
    class RandomGuess

    {
        public static   void Guess()
        {
            var myRandom = new Random();
            var answer = myRandom.Next(1, 10);
            var count = 5;

            for (var i = 5; i > 0; i--)
            {
                Console.WriteLine("Lets play a game... Guess my number between 1 and 10. You have " + count + " tries left.");
                count--;
                var response = Console.ReadLine();
                var responseNum = int.Parse(response);
                if(answer == responseNum)
                {
                    Console.WriteLine("Congratulations, You win this time!");
                    
                    return;
                }else
                {
                    Console.WriteLine("Try Again");
                }

            }
            Console.WriteLine("Sorry, Better luck next time!");

            Console.ReadLine();

        }
    }
}
