using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    class CheckAnswer
    {       
        public bool IsCorrect(Questions question)
        {
            var userAnswer = new PrintToScreen().UserInput(question);
            var isTrue = false;
            foreach (var option in question.Options)
            {
                if (option.Correct == true && option.Number == userAnswer)
                {
                    isTrue = true;
                }
            }
            return isTrue;
        }

    }
}



/*
  else
                {
                    Console.WriteLine
                } 
*/