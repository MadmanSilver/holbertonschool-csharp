using System;

namespace Text
{
    /// <summary> Class containing string methods. </summary>
    public class Str
    {
        /// <summary> Counts the number of words in a camel case string. </summary>
        public static int CamelCase(string s) {
            int words = 1;

            if (s.Length == 0) {
                return 0;
            }

            foreach (char c in s) {
                if (c >= 'A' && c <= 'Z') {
                    words++;
                }
            }

            return words;
        }
    }
}
