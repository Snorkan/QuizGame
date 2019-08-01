using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizGame
{
    public class ReadFile
    {   
        public string ReadJson(string fileName)
        {
            string jsonTxt = string.Empty;
            using (StreamReader r = new StreamReader(fileName))
            {
                var json = r.ReadToEnd();
                jsonTxt = json.ToString();
            }

            return jsonTxt;
            
        }
        
        public QuestionCollection ConvertToQuestionCollection(string jsonTxt)
        {
            var questionCollection = JsonConvert.DeserializeObject<QuestionCollection>(jsonTxt);
            return questionCollection;
        }

        public UserList ConvertToUserList(string jsonTxt)
        {
            var userList = JsonConvert.DeserializeObject<UserList>(jsonTxt);
            return userList;
        }
    }
}
