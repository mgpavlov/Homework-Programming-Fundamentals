using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            //<pp><p>.+?<\/p>)
            
            var text = Console.ReadLine();
            var pattern1 = @"(?<=<p>)(.+?)(?=<\/p>)";
            MatchCollection matches = Regex.Matches(text, pattern1);

            var pattern2 = @"[^a-z0-9]";
            var result = "";
            foreach (Match match in matches)
            {
                result += Regex.Replace(match.ToString(), pattern2, " ");
            }
            result = Regex.Replace(result, @"\s+", " ");
            var str = result.ToCharArray();
            var print = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]>='a'&& str[i]<='m')
                {
                    print[i] = (char)(str[i] + 13);
                }
                else if (str[i] >= 'n' && str[i] <= 'z')
                {
                    print[i] = (char)(str[i] - 13);
                }
                else
                {
                    print[i] = str[i];
                }
                Console.Write(print[i]);
            }
        }
    }
}
