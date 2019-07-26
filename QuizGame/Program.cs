using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

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
            //QuestionCollection questionCollection = new ReadJson().QC(fileName);

            /*List<int> usedQuestions = new List<int>();
            int randomNumber = new Random().Next(1, maxInt);
            usedQuestions.Add(randomNumber);*/
            
            string jsonTxt = string.Empty;
            using (StreamReader r = new StreamReader(fileName))
            {
                var json = r.ReadToEnd();
                jsonTxt = json.ToString();
            }

            var questionCollection = JsonConvert.DeserializeObject<QuestionCollection>(jsonTxt);

            int maxInt = questionCollection.Questions.Count + 1;

            int score = 0;

            for (int i = 1; i < maxInt; i++)
            {
                int[] scoreTracker = new QuestionCollectionManager().ReturnQuestion(questionCollection, i);
                score += scoreTracker[1];
                Console.WriteLine(score);
            }
            

            

        }
    }
}


