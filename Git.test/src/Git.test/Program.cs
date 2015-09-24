using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Git.test
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello Git");
            Console.WriteLine("Här får man välja kategorin");
            Console.WriteLine("Skriv en av kategorierna:");
            Console.WriteLine("Sport S");
            Console.WriteLine("Historia H");
            Console.WriteLine("Popkultur P");
            string answer = Console.ReadLine();
            Quizzes quiz = new Quizzes();

            switch (answer)
            {
                case "S":
                    quiz.SportQuestion();
                    break;
                default:
                    break;
            }

        }
    }
}
