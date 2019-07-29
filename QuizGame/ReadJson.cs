using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizGame
{
    public class ReadJson
    {   
        public QuestionCollection ConvertJsonToObject(string fileName)
        {
            string jsonTxt = string.Empty;
            using (StreamReader r = new StreamReader(fileName))
            {
                var json = r.ReadToEnd();
                jsonTxt = json.ToString();
            }

            var questionCollection = JsonConvert.DeserializeObject<QuestionCollection>(jsonTxt);
            return questionCollection;
        }   
    }
}
