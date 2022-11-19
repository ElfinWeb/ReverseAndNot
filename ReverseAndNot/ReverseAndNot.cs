using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndNot
{
    public class ReverseAndNot
    {
        public static string ReverseAndPlace(string text)
        {
            string reverseText = "";

            for (int i = (text.Length - 1); i >= 0; i--)
            {
                reverseText += text[i];
            }

            return text + reverseText;
        }
    }
}
