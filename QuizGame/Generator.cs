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
    }
}
