using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    public static class StringBuilderExtensions
    {
        public static String SubString (this StringBuilder str, int startIndex, int lenght)
        {
            String output = "";

            if (startIndex > str.Length || startIndex < 0 || lenght < 0)
                throw new ArgumentOutOfRangeException("startIndex and lenght must be > 0");

            for (int i = startIndex; i < startIndex + lenght; i++)
            {
                if (i > str.Length - 1)
                    throw new IndexOutOfRangeException("The startIndex and Lenght exceed the input string lenght! ");
                output += str[i];
            }

            return output;
        }

        public static StringBuilder RemoveText (this StringBuilder str, string text)
        {
            text = text.ToLower();
            string loweredStr = str.ToString().ToLower();

            List<int> matches = new List<int>();

            for (int i = 0; i < loweredStr.Length; i++)
            {
                if (loweredStr[i].Equals(text[0]))
                {
                    bool match = true;
                    for (int j = 0; j < text.Length; j++)
                    {
                        if (!loweredStr[i + j].Equals(text[j]))
                            match = false;
                    }
                    if (match)
                    {
                        if (matches.Count == 0)
                            matches.Add(i);
                        else
                            matches.Add(i - text.Length);
                    }
                }
            }

            foreach (var index in matches)
            {
                str.Remove(index, text.Length);
            }

            return str;
        }

        public static StringBuilder AppendAll<T> (this StringBuilder str, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                str.Append(" ")
                   .Append(item.ToString());
            }

            return str;
        }
    }
}
