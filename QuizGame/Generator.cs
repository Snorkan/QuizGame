using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizGame
{
    public class Generator
    {
        public List<int> QuestionIds(int maxInt)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i < maxInt; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }


        
        public int SelectRandom(QuestionCollection questionCollection)
        {
            int maxInt = questionCollection.Questions.Count + 1;

            // question id 1, 2, 3, 4 ... maxInt
            List<int> questionId = new Generator().QuestionIds(maxInt);

            int score = 0;
            for (int i = 1; i < maxInt; i++)
            {
                int questionsLeft = questionId.Count;
                int randomNumber = new Random().Next(0, questionsLeft);

                int[] scoreTracker = new QuestionCollectionManager().ReturnQuestion(questionCollection, questionId[randomNumber]);

                questionId.RemoveAt(randomNumber);
                score += scoreTracker[1];

            }
            return score;
        }

    }
}
