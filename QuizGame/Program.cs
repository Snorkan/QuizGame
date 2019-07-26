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

            string jsonTxt = string.Empty;
           
            using (StreamReader r = new StreamReader(fileName))
            {
                var json = r.ReadToEnd();
                jsonTxt = json.ToString();
            }
            
            var questionCollection = JsonConvert.DeserializeObject<QuestionCollection>(jsonTxt);

            int maxInt = questionCollection.Questions.Count + 1;

            for (int i = 0; i < maxInt; i++)
            {
                int randomNumber = new Random().Next(1, 3);
                new QuestionCollectionManager().ReturnQuestion(questionCollection, randomNumber);
            }

            

        }
    }
}


