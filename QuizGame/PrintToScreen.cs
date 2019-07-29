using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    class PrintToScreen
    {

        public string GiveName()
        {
            string userName;
            Console.WriteLine("Hello, plz give name.");
            userName = Console.ReadLine();
            userName = new Format().FormatName(userName);
            Console.WriteLine($"ok {userName}, now u answer the questions with the corresponding number.");
            return userName;
        }

        public string PrintOptions(Questions question)
        {
            Console.WriteLine(question.Question);
            foreach (var option in question.Options)
            {
                Console.WriteLine($"{option.Number}. {option.Option}");
            }
            return null;
        }

        public int UserInput(Questions question)
        {
            new PrintToScreen().PrintOptions(question);

            Console.Write("Plz give answer: ");
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);
            return number;
        }

        public int[] ReturnTrue(int[] scoreTracker)
        {
            //string message = string.Empty;
            switch (scoreTracker[0])
            {
                case 2:
                    scoreTracker[1] = 5;
                    scoreTracker[0] = 0;
                    Console.WriteLine($"Good job, u got {scoreTracker[1]} points!!");
                    return scoreTracker;
                case 1:
                    scoreTracker[1] = 3;
                    scoreTracker[0] = 0;
                    Console.WriteLine($"Good job, u got {scoreTracker[1]} points!!");
                    return scoreTracker;
                case 0:
                    scoreTracker[1] = 1;
                    scoreTracker[0] = 0;
                    Console.WriteLine($"Good job, u got {scoreTracker[1]} points!!");
                    return scoreTracker;
            }
            return scoreTracker;
        }

        public int[] ReturnFalse(int[] scoreTracker)
        {
            switch (scoreTracker[0])
            {
                case 2:
                    Console.WriteLine($"Not quite right, plz try again!");
                    return scoreTracker;
                case 1:
                    Console.WriteLine($"Oh no u wrong again...");
                    return scoreTracker;
                case 0:
                    Console.WriteLine($"u bad. Next question for u.");
                    return scoreTracker;
            }
            return scoreTracker;
        } 

    }
}