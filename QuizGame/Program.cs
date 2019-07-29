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

            string fileName = @"C:\QuizGame\QuestionAnswer.json";

            string userName = new PrintToScreen().GiveName();

            QuestionCollection questionCollection = new ReadJson().ConvertJsonToObject(fileName);

            int score = new Generator().ScoreTracker(questionCollection);

            Dictionary<string, int> userScore = new Dictionary<string, int>();
            userScore.Add(userName, score);

            foreach (KeyValuePair<string, int> kvp in userScore)
            {
                Console.WriteLine("Name: {0}, Score = {1} points", kvp.Key, kvp.Value);
            }
            
        }
    }
}


