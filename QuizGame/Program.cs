using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string userName;
            Console.WriteLine("Hi, write your name plz.");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, let's start playing hehehe."); */

            string fileName = @"C:\QuizGame\QuestionAnswer.json";
            QuestionCollection questionCollection = new ReadJson().QC(fileName);

            int maxInt = questionCollection.Questions.Count + 1;

            int score = 0;

            // question id 1, 2, 3, 4 ... maxInt
            List<int> questionId = new Generator().QuestionIds(maxInt);

            for (int i = 1; i < maxInt; i++)
            {
                int l = questionId.Count;
                int randomNumber = new Random().Next(0, l);

                int[] scoreTracker = new QuestionCollectionManager().ReturnQuestion(questionCollection, questionId[randomNumber]);

                questionId.RemoveAt(randomNumber);
                score += scoreTracker[1];

                if (l == 1) {
                    Console.WriteLine($"Your total score is: {score}!!");
                }
                
            }
        }
    }
}


