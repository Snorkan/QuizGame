using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    class Format
    {
        public string FormatName(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1);

        }

    }
}
