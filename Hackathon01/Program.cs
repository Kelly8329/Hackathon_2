using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入年收入：");
            int Annualincome = int.Parse(Console.ReadLine());
            double Calculation = 0;
            decimal money = 0;
            //年收入最大值
            int A = 540000;
            int B = 1210000;
            int C = 2420000;
            int D = 4530000;
            int E = 10310000;
            //稅率
            double A1 = 0.05;
            double B1 = 0.12;
            double C1 = 0.2;
            double D1 = 0.3;
            double E1 = 0.4;
            double F1 = 0.5;

            if (Annualincome <= A)//級距1
            {
                Calculation = Annualincome * A1;
                money = (decimal)Calculation;
                Console.WriteLine("應繳納稅額：" + money.ToString("C"));
            }

            else if (Annualincome <= B)//級距2
            {
                Calculation = Annualincome * B1 - (A * (B1 - A1));
                money = (decimal)Calculation;
                Console.WriteLine("應繳納稅額：" + money.ToString("C"));
            }

            else if (Annualincome <= C)//級距3
            {
                Calculation = Annualincome * C1 - ((A * (C1 - A1)) + ((B - A) * (C1 - B1)));
                money = (decimal)Calculation;
                Console.WriteLine("應繳納稅額：" + money.ToString("C"));
            }

            else if (Annualincome <= D)//級距4
            {
                Calculation = Annualincome * D1 - ((A * (D1 - A1)) + ((B - A) * (D1 - B1)) + ((C - B) * (D1 - C1)));
                money = (decimal)Calculation;
                Console.WriteLine("應繳納稅額：" + money.ToString("C"));
            }

            else if (Annualincome <= E)//級距5
            {
                Calculation = Annualincome * E1 - ((A * (E1 - A1)) + ((B - A) * (E1 - B1)) + ((C - B) * (E1 - C1)) + ((D - C) * (E1 - D1)));
                money = (decimal)Calculation;
                Console.WriteLine("應繳納稅額：" + money.ToString("C"));
            }

            else
            {
                Calculation = Annualincome * F1 - ((A * (F1 - A1)) + ((B - A) * (F1 - B1)) + ((C - B) * (F1 - C1)) + ((D - C) * (F1 - D1)) + (E - D) * (F1 - E1));
                money = (decimal)Calculation;
                Console.WriteLine("應繳納稅額：" + money.ToString("C"));
            }

            Console.ReadLine();
        }
    }
}
