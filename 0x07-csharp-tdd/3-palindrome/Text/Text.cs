using System;

namespace Text
{
    /// <summary> Class containing string methods. </summary>
    public class Str
    {
        /// <summary> Checks if a string is a palindrome. </summary>
        public static bool IsPalindrome(string s) {
            int l = 0;
            int r = s.Length - 1;
            string lower = s.ToLower();

            if (s.Length < 2) {
                return true;
            }

            while (lower[l] < 'a' || lower[l] > 'z') {
                l++;
            }
            while (lower[r] < 'a' || lower[r] > 'z') {
                r--;
            }

            while (lower[l] == lower[r]) {
                l++;
                r--;

                while (lower[l] < 'a' || lower[l] > 'z') {
                    l++;
                }
                while (lower[r] < 'a' || lower[r] > 'z') {
                    r--;
                }

                if (l >= r) {
                    return true;
                }
            }

            return false;
        }
    }
}
