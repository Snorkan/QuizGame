using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;


namespace QuizGame
{
    public class Save
    {
 
        public void SaveToFile(string fileName, UserList userList)
        {
            var json = JsonConvert.SerializeObject(userList);

            using (StreamWriter writetext = new StreamWriter(fileName))
            {
                writetext.WriteLine(json);
            }

        }
    }
}
