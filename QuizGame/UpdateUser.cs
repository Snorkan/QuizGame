using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuizGame
{
    public class UpdateUser
    {
        public int ReturnScoreIfNameExists(UserList userList, string userName)
        {
            int score = 0;

            for (int index = userList.Users.Count - 1; 
                index >= 0; index--)
            {
                if (userList.Users.ElementAt(index).Name == userName)
                {
                    score = userList.Users.ElementAt(index).Score;
                    userList.Users.RemoveAt(index);
                }
            }
            return score;
        }

        public void AddScore(UserList userList, string userName, int score)
        {
            User newUser = new User()
            {
                Name = userName,
                Score = score
            };
            userList.Users.Add(newUser);
        }
    }
}
