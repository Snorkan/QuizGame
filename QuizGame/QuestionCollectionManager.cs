using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    class QuestionCollectionManager
    {
        public void ReturnQuestion(QuestionCollection questionCollection, int questionNumber)
        {
            Questions question = new Manager().ChooseQuestion(questionCollection, questionNumber);
            new Manager().Loopiloop(question, 3);
        } 
        
    }
}
