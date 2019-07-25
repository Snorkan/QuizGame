using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    class PrintToScreen
    {
        public string PrintOptions(Questions question)
        {
            Console.WriteLine(question.Question);
            foreach (var option in question.Options)
            {
                Console.WriteLine($"{option.Number}. {option.Option}");
            }
            return null;
        }

        public int UserInput(Questions question)
        {
            new PrintToScreen().PrintOptions(question);

            Console.Write("Plz give answer: ");
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);
            return number;
        }
    }
}
