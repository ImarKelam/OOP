using System;

namespace _02_Static_Members_And_Namespaces._04_HTML_Dispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string imgSrc, string alt, string title)
        {
            if (imgSrc == null || alt == null || title == null)
                throw new ArgumentNullException("All fields are mandatory!"); 

            return "<img src=\"" + imgSrc + "\" alt=\"" + alt + "\" title=\"" + title + "\"/>";
        }

        public static string CreateURL(string url, string title, string text)
        {
            if (url == null || title == null || text == null)
                throw new ArgumentNullException("All fields are mandatory!");

            return "<a href=\"" + url + "\" title=\"" + title + "\">" + text + "</a>";
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            if (inputType == null || name == null || value == null)
                throw new ArgumentNullException("All fields are mandatory!");

            return "<input type=\"" + inputType + "\" name=\"" + name + "\" value=\"" + value + "\"/>";
        }
    }
}
