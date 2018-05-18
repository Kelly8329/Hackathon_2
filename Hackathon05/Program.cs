using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("判斷是否為回文");
            for (int i = 0; i <2; i++)
            {
                Console.Write("請輸入一個字串：");
                var s1 = Console.ReadLine();
                Console.WriteLine(test.decide(s1));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public static class test
    {
        public static string decide(string s1)
        {
            char[] array = s1.ToCharArray();
            Array.Reverse(array);
            var s2 = new string(array);

            if (s1 == s2)
            {
                return ("是回文");
            }
            else
            {
                return ("不是回文");
            }
        }

    }
}
