using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    public class Manager
    {

        //from the question collection -> single out one question object
        public Questions ChooseQuestion(QuestionCollection collection, int QuestionNumber)
        {

            foreach (var question in collection.Questions)
            {
                if (question.QuestionId == QuestionNumber)
                {
                    return question;
                }
            }
            return null;
        }
        // 
        public int[] Loopiloop(Questions question, int[] scoreStats)
        {
            //int i = scoreStats[1];

            while (scoreStats[1] > 0)
            {
                scoreStats = new Manager().Countdown(question, scoreStats[1]);
            }
            return scoreStats;
        }

        //
        public int[] Countdown(Questions question, int count)
        {
            int score = 0;
            count--;
            bool correct = new CheckAnswer().IsCorrect(question);

            if (correct == true) {
                Console.WriteLine("Correct!");
                switch (count)
                {
                    case 2:
                        score = 5;
                        break;
                    case 1:
                        score = 3;
                        break;
                    case 0:
                        score = 1;
                        break;
                }
                count = 0;

            } else
            {
                switch (count)
                {
                    case 2:
                        Console.WriteLine($"Not quite right, plz try again!");
                        break;
                    case 1:
                        Console.WriteLine($"Oh no u wrong again...");
                        break;
                    case 0:
                        Console.WriteLine($"u bad. Next question for u.");
                        break;
                }
            }
            int[] scoreStats = { score, count };
            return scoreStats;
        }

        
    }
}
