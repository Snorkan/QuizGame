using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    class CheckAnswer
    {

        public bool CompareAnswer(Questions question) {
            int userAnswer = new PrintToScreen().UserInput(question);
            bool isTrue = new CheckAnswer().IsTrue(question, userAnswer);
            return isTrue;
        }
        
        public bool IsTrue(Questions question, int userAnswer)
        {
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