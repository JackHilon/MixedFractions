using System;
using System.Collections.Generic;

namespace MixedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mixed Fractions
            // https://open.kattis.com/problems/mixedfractions
            // simple program
            // I get error: wrong answer -- but I think my program is right!!!!
            // ==================================================================

            var parameters = new int[2];
            int myNum, myDen;
            var answers = new List<string>();
            while (true)
            {
                parameters = Enter2Num();
                myNum = parameters[0];
                myDen = parameters[1];

                if (myDen == 0 && myNum == 0)
                    break;

                answers.Add(FractionFormat(myNum, myDen));
            }

            PrintList(answers);
        }
        private static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static string FractionFormat(int num, int den)
        {
            // numerator / denominator
            int qot;
            int res;
            if (den == 0 && num != 0)
                return $"0 {num} / 0 ";
            else if (den == 0 && num == 0)
                return $"0 0 / 0 "; // 0 3 / 4000
            else if (num <= den)
                return $"0 {num} / {den} "; // 0 3 / 4000

            else
            {
                // qot = num / den;
                res = num % den;
                qot = (num - res) / den;
                return $"{qot} {res} / {den} ";
            }
        }
        private static int[] Enter2Num()
        {
            var res = new int[2];
            var arr = new string[2];
            try
            {
                arr = Console.ReadLine().Split(' ', 2);
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                    //if (res[i] < 1)
                    //    throw new ArgumentException();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enter2Num();
            }
            return res;
        }
    }
}
