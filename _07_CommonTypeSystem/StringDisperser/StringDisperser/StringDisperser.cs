namespace StringDisperser
{
    using System;
    using System.Collections;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string content;

        public StringDisperser(string firstString, string secondString, string thirdString)
        {
            Content = firstString + secondString + thirdString;
        }

        // I am using this private constructor just for the Clone method
        private StringDisperser(string str)
        {
            this.content = str;
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public override string ToString()
        {
            return content.ToString();
        }

        public override int GetHashCode()
        {
            return content.GetHashCode();
        }

        public override bool Equals(object param)
        {
            StringDisperser str = param as StringDisperser;

            if (str == null)
                return false;

            if (!Object.Equals(this.content, str))
                return false;

            return true;
        }

        public static bool operator == (StringDisperser str1, StringDisperser str2)
        {
            return StringDisperser.Equals(str1, str2);
        }

        public static bool operator != (StringDisperser str1, StringDisperser str2)
        {
            return !(StringDisperser.Equals(str1, str2));
        }

        public object Clone()
        {
            StringDisperser newString = new StringDisperser(this.Content);

            return newString;
        }

        public int CompareTo(StringDisperser otherContent)
        {
            return this.content.ToString()
                .CompareTo(otherContent.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            var str = this.Content.ToString();
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                yield return str[i];
            }
        }
    }
}
