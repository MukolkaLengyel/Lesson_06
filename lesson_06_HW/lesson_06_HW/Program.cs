using System.Collections.Generic;

namespace lesson_06_HW
{
    internal class Program
    {
        //Compare strings
        static void Compare(string s1, string s2, string s3)
        {
            Boolean result_of_first_compare = s1.Equals(s2);
            Console.WriteLine("The result of first two strings is: " + result_of_first_compare);

            Boolean result_of_second_compare = s1.Equals(s3);
            Console.WriteLine("The result of first and third strings is: " + result_of_second_compare);

        }

        //Analyze strings
        static void Analyze(string analyzeStr)
        {
           int AlphabeticNum = 0;
           int DigitsNum = 0; 
           int SpecialNum = 0;

           foreach (char str in analyzeStr)
            {
                if (char.IsLetter(str))
                {
                    AlphabeticNum++;
                }

                else if (char.IsDigit(str))
                {
                    DigitsNum++;
                }

                else
                {
                    SpecialNum++;
                }

                Console.WriteLine("Alphabetic Characters: " + AlphabeticNum);
                Console.WriteLine("Digits Characters: " + DigitsNum);
                Console.WriteLine("Special Characters: " + SpecialNum);
            }
        }

        //Sort srting
        static string Sort (string sortStr)
        {
            char[] chars = sortStr.ToCharArray();
            Array.Sort(chars);

            string Sort = new string(chars);
            sortStr = new string(chars);
            Console.WriteLine("Sorted String: " + sortStr);
            return sortStr;
        }

        //Duplicate string
        public char[] Duplicate(string dubS)
        {
            List<char> duplicates = new List<char>();


            for (int i = 0; i < dubS.Length; i++)
            {
                char c = dubS[i];


                if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                {

                    if (dubS.IndexOf(c, i + 1) != -1 && !duplicates.Contains(c))
                    {
                        duplicates.Add(c); // add the duplicated character to the list
                    }
                }
            }


            Console.Write("Duplicated Characters: ");
            foreach (char c in duplicates)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            return duplicates.ToArray();
        }

        static void Main(string[] args)
        {
            string s1 = "Creative Kid";
            string s2 = "Creative Kid";
            string s3 = "Kreative Kiddo";
            Compare(s1, s2, s3);

            string analyzeStr = "94";
            Analyze(analyzeStr);

            string sortStr = "hello my dear friend";
            Sort(sortStr);

        }
    }
}