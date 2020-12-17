using System;

namespace Text
{
    /// <summary> Class containing string methods. </summary>
    public class Str
    {
        /// <summary> Gets the index of the first unique character in a string. </summary>
        public static int UniqueChar(string s) {
            for (int cur = 0; cur < s.Length; cur++) {
                for (int chk = 0; chk < s.Length; chk++) {
                    if (chk == cur) {
                        if (chk == s.Length - 1) {
                            return cur;
                        }
                        continue;
                    }

                    if (s[cur] == s[chk]) {
                        break;
                    }

                    if (chk == s.Length - 1) {
                        return cur;
                    }
                }
            }

            return -1;
        }
    }
}
