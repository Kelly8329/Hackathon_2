using Hackathon_2_06.NewFolder1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "test03.txt";

            if (File.Exists(FileName))
            {
                string[] lines = File.ReadAllLines(FileName).ToArray();
                string tmpTickNumber = string.Empty;
                DateTime tmpFlyingDay = new DateTime(), tmpBirthday = new DateTime();
                string tmp = string.Empty;
                TestModel model = new TestModel();
                foreach (var i in lines)
                {
                    if (i.Substring(0, 3) == "695" || i.Substring(0, 3) == "525")
                        tmpTickNumber = i.Substring(0, 12);
                    else
                        continue;
                    if (DateTime.TryParseExact(i.Substring(13, 8), "yyyyMMdd", null, DateTimeStyles.None, out DateTime dateTime))
                        tmpFlyingDay = dateTime;
                    else
                        continue;
                    if (DateTime.TryParseExact(i.Substring(21, 8), "yyyyMMdd", null, DateTimeStyles.None, out dateTime))
                        tmpBirthday = dateTime;
                    else
                        continue;

                    TextTable table = new TextTable()
                    {
                        TickNumber = tmpTickNumber,
                        FlyingDay = tmpFlyingDay,
                        BirthDay = Convert.ToDateTime(tmpBirthday)
                    };

                    model.TextTable.Add(table);
                    model.SaveChanges();
                }

                Console.WriteLine("檔案建立完成");
            }
            else
            {
                Console.WriteLine("檔案不存在");
                Console.ReadLine();
            }

            TestModel m = new TestModel();
            foreach (var i in m.TextTable)
            {
                Console.WriteLine(i.TickNumber + i.FlyingDay + i.BirthDay);
                Console.ReadLine();
            }

        }
    }
}
