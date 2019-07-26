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

            // question id 1, 2, 3, 4 ... maxInt
            List<int> questionId = new Generator().QuestionIds(maxInt);

            
            for (int i = 1; i < maxInt; i++)
            {
                int l = questionId.Count;

                Console.WriteLine($"items in list: {l}");

                int randomNumber = new Random().Next(0, l);

                Console.WriteLine($"Random number in loop: {randomNumber}");
                // remove at index randomnumber
                
                int[] scoreTracker = new QuestionCollectionManager().ReturnQuestion(questionCollection, questionId[randomNumber]);

                questionId.RemoveAt(randomNumber);

                Console.WriteLine($"items left: {l}");

                score += scoreTracker[1];
                Console.WriteLine($"Your total score is: {score}!!");
            }
            

            
            


        }
    }
}


