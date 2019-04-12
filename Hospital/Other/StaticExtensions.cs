using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Other
{
    public static class StaticExtensions
    {
        public static string RemovePostfixes(this string s,string[] postfixes)
        {
            if (s != null)
            {
                var postfixesList = postfixes.ToList().OrderByDescending(x => x.Length);
                foreach (var postfix in postfixesList)
                {
                    s = s.Replace(postfix, "");
                }
            }

            return s;
        }


        /// <summary>
        /// Compute the similarity of two strings using the Levenshtein distance.
        /// </summary>
        /// <param name="s">The first string.</param>
        /// <param name="t">The second string.</param>
        /// <returns>Levenshtein distance between strings</returns>
        public static int GetLvenshteinDistance(this string s, string t)
        {
            if (t != null)
            {
                int maxLen = Math.Max(s.Length, t.Length);

                if (maxLen == 0)
                {
                    return 0;
                }


                s = s.ToLowerInvariant();
                t = t.ToLowerInvariant();

                float dis = Distance(s, t);

                return (int) dis;
            }

            return int.MaxValue;
        }

        private static int Distance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1]; // matrix
            int cost = 0;

            if (n == 0) return m;
            if (m == 0) return n;

            // Initialize.
            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 0; j <= m; d[0, j] = j++) ;

            // Find min distance.
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    cost = (t.Substring(j - 1, 1) == s.Substring(i - 1, 1) ? 0 : 1);
                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
                }
            }

            return d[n, m];
        }

    }
}
