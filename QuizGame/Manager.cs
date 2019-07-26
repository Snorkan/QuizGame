using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    public class Manager
    {
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


        public int Countdown(Questions question, int count)
        {
            count--;
            bool correct = new CheckAnswer().IsCorrect(question);

            if (correct == true) {
                Console.WriteLine("Correct!");
                count = 0;
            } else
            {
                switch (count)
                {
                    case 2:
                        Console.WriteLine($"Not quite right, plz try again!");
                        return count;
                    case 1:
                        Console.WriteLine($"Oh no u wrong again...");
                        return count;
                    case 0:
                        Console.WriteLine($"u bad. Next question for u.");
                        return count;
                }
            }
            return count;
        }

        public int Loopiloop(Questions question, int i)
        {
            while (i > 0)
            {
                i = new Manager().Countdown(question, i);
            }
            return i;
        }
    }
}
