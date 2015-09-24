using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Git.test
{
    public class Quizzes
    {
        public Quizzes()
        {

        }

        public void SportQuestion()
        {
            Console.WriteLine("Vilket är sveriges bästa hockeylag?");
            Console.WriteLine("A: Brynäs");
            Console.WriteLine("B: Timrå");
            Console.WriteLine("C: Skellefteå");
            Console.WriteLine("D: Luleå");
            string answer=Console.ReadLine();
            if (answer.Equals("A"))
            {
                Console.WriteLine("Rätt svar!!");
            }
            else
            {
                Console.WriteLine("Fel svar!!");
            }

        }
    }
}
