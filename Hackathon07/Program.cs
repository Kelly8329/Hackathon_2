using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字");
            string n1 = Console.ReadLine();
            char[] arychar = n1.ToCharArray();
            string top = "";
            string mid = "";
            string end = "";

            for (int i = 0; i < arychar.Length; i++)
            {
                switch (arychar[i])
                {
                    case '0':
                        top += "|￣|";
                        mid += "|　|";
                        end += " ￣ ";
                        break;

                    case '1':
                        top += " 　|";
                        mid += " 　|";
                        end += " 　 ";
                        break;

                    case '2':
                        top += " ￣|";
                        mid += "|￣ ";
                        end += " ￣ ";
                        break;

                    case '3':
                        top += " ￣|";
                        mid += " ￣|";
                        end += " ￣ ";
                        break;

                    case '4':
                        top += "|　|";
                        mid += " ￣|";
                        end += "    ";
                        break;

                    case '5':
                        top += "|￣ ";
                        mid += " ￣|";
                        end += " ￣ ";
                        break;

                    case '6':
                        top += "|￣ ";
                        mid += "|￣|";
                        end += " ￣ ";
                        break;

                    case '7':
                        top += " ￣|";
                        mid += " 　|";
                        end += "    ";
                        break;

                    case '8':
                        top += "|￣|";
                        mid += "|￣|";
                        end += " ￣ ";
                        break;

                    case '9':
                        top += "|￣|";
                        mid += " ￣|";
                        end += " ￣ ";
                        break;
                } 
            }
            Console.WriteLine(top);
            Console.WriteLine(mid);
            Console.WriteLine(end);
            Console.ReadLine();
        }
    }
}
