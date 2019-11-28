using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisparityChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "aa";
            String s2 = "ababaa";
           /* int n = Convert.ToInt32(s.Length);
            int n2 = Convert.ToInt32(s2.Length);*/

            String [] strings = new String [2] { s, s2 };
            int[] finalResult  =usernameDisparity(strings);

            for (int i = 0; i < finalResult.Length; i++)
            {
                Console.Write("{0}  ", finalResult[i]);
            }
            Console.ReadLine();
            
         /*   Console.WriteLine(sumofSimilarity(s, n).ToString());
            Console.WriteLine(sumofSimilarity(s2, n2).ToString());*/
        }


        public static int[] usernameDisparity( String [] strings) {

            int[] resultList = new int[2];
            for (int i = 0; i < strings.Length; i++)
            {
                resultList[i] = sumofSimilarity(strings[i]);
            }
            return resultList;
        }


        public static int sumofSimilarity(string s)
        {
            int total = 0;

            char[] inputArr = s.ToCharArray();
            for (int i = 1; i < inputArr.Length; i++)
            {
                int count = 0;
                for (int j = i; j < inputArr.Length; j++)
                {
                    if (inputArr[j - i] != inputArr[j])
                    {
                        break;
                    }
                    count++;
                }
                total += count;
            }
            return total + inputArr.Length;
        }
    }
}
