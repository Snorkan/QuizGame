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
        public int[] Loopiloop(Questions question, int[] scoreTracker)
        {
            //scoreStats[0] is the count
            
            while (scoreTracker[0] > 0)
            {
                bool isTrue = new CheckAnswer().CompareAnswer(question);
                scoreTracker = new Manager().Countdown(question, scoreTracker, isTrue);
            }
            return scoreTracker;
        }

        //
        public int[] Countdown(Questions question, int[] scoreTracker, bool isTrue)
        {
            //scoreTracker[0] = count of how many attempt you got left
            //scoreTracker[1] = keep track of score

            scoreTracker[0]--;

            return new PrintToScreen().ReturnScore(scoreTracker, isTrue);
        }

        
    }
}


