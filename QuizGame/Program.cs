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


            int randomNumber = new Random().Next(1,3);

            Questions question = new Manager().ChooseQuestion(questionCollection, randomNumber);

            new Manager().Loopiloop(question, 3);

            

        }
    }
}


