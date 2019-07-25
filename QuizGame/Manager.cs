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

            if (correct == true)
            {
                Console.WriteLine("Correct!");
                count = 0;
            } else
            {
                Console.WriteLine($"No this is wrong, plz try again.You have now {count} attempts left.");
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
