using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {


        
            public static string LongestCommonPrefix(string[] strs)
            {

                int minLength = 0;
                string prefix = "";
                int indexSize = strs.Length;

                for (int i = 0; i <= strs[0].Length; i++)
                {

                    prefix = strs[0].Substring(0, i);

                    for (int j = 0; j < indexSize; j++)

                        if (strs[j].Length < i)
                        {
                            return prefix;
                        }
                        if (prefix != strs[j].Substring(0, i))
                        {
                            prefix = prefix.Substring(0, i - 1);
                            return prefix;
                        }
                }





                return prefix;




            }
        




        static void Main(string[] args)
        {

            string[] strs = { "ab", "a" };

            Console.WriteLine(LongestCommonPrefix(strs));

        }
    }
}