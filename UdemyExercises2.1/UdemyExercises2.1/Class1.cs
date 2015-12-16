using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercises2._1
{
    class Class1
    {
        public static void Ask()
        {
            var result = 0;
            var answer = "";
            var num = true;
            var answerNum = 0;
            while (num)
            {
                Console.WriteLine("Enter a number or press ok to exit");
                answer = Console.ReadLine();
                if(answer == "ok")
                {
                    Console.WriteLine(result);
                    num = false;
                }else
                {   
                    answerNum = int.Parse(answer);
                    result += answerNum;
                    Console.WriteLine("The sum is " + result);
                }
            }
        }
    }
}