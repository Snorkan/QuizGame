using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    public class QuestionCollectionManager
    {
        public int[] ReturnQuestion(QuestionCollection questionCollection, int questionNumber)
        {
            int initializeCount = 3;
            int score = 0;
            int[] scoreTracker = { initializeCount, score };

            Questions question = new Manager().ChooseQuestion(questionCollection, questionNumber);

            scoreTracker = new Manager().Loopiloop(question, scoreTracker);
            return scoreTracker;
        } 
        
    }
}
