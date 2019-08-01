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

            
            string fileQA = @"C:\QuizGame\QuestionAnswer.json";
            string fileHighscore = @"C:\QuizGame\Highscore.json";

            string userName = new PrintToScreen().GiveName();

            string txtQA = new ReadFile().ReadJson(fileQA);
            string txtHighscore = new ReadFile().ReadJson(fileHighscore);

            QuestionCollection questionCollection = new ReadFile().ConvertToQuestionCollection(txtQA);
            UserList userList = new ReadFile().ConvertToUserList(txtHighscore);

            int score = new Generator().SelectRandom(questionCollection);

            //if new user, this returns 0. Old user returns saved scoring. 
            int oldScore = new UpdateUser().ReturnScoreIfNameExists(userList, userName);

            int newScore = score + oldScore; 

            //adds new user to the list
            new UpdateUser().AddScore(userList, userName, newScore);

            //save to userlist json

            new Save().SaveToFile(fileHighscore, userList);

        }
    }
}


