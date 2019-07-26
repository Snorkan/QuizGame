using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    public class ReturnMessage
    {
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
        
    }
}
