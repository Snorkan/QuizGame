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
                scoreTracker = new Manager().Countdown(question, scoreTracker);
            }
            return scoreTracker;
        }

        //
        public int[] Countdown(Questions question, int[] scoreTracker)
        {
            //scoreTracker[0] = count of how many attempt you got left
            //scoreTracker[1] = keep track of score

            //countdown count - 1
            scoreTracker[0]--;
            
            
            bool correct = new CheckAnswer().IsCorrect(question);
            
            if (correct == true) {
                Console.WriteLine("Correct!");
                switch (scoreTracker[0])
                {
                    case 2:
                        scoreTracker[1] = 5;
                        scoreTracker[0] = 0;
                        return scoreTracker;
                    case 1:
                        scoreTracker[1] = 3;
                        scoreTracker[0] = 0;
                        return scoreTracker;
                    case 0:
                        scoreTracker[1] = 1;
                        scoreTracker[0] = 0;
                        return scoreTracker;
                }
                

            } else
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
            }
            
            return scoreTracker;
        }

        
    }
}


