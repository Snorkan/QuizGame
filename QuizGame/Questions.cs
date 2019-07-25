using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    public class Questions
    {
        public Questions()
        {

        }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public List<OptionType> Options { get; set; }
    }
}
