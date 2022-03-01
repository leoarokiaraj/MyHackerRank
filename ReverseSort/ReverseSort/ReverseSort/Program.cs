using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ts1_input";
            string path = @"C:\@MyData\Leo\Code\ReverseSort\TestData\";

            TextReader reader = new StreamReader(path + name + ".txt");
            TextWriter writer = new StreamWriter(path + name + "_out.txt");

            //TextReader reader = System.Console.In;
            //TextWriter writer = System.Console.Out;

            int testCases = int.Parse(reader.ReadLine());
            for (int testCase = 1; testCase <= testCases; testCase++)
            {
                string sLen = reader.ReadLine();
                List<int> sInputArr = new List<int>();
                sInputArr.AddRange(reader.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList());
                int iLen = 0, j = 0, res = 0, revCount = 0, tempRes = 0;
                int.TryParse(sLen, out iLen);
                for (int i = 1; i <= iLen - 1; i++)
                {
                    j = sInputArr.FindIndex(i - 1, x => x == sInputArr.GetRange(i - 1, iLen - (i - 1)).Min());
                    revCount = (j - i) + 2;
                    if (revCount > 1)
                        sInputArr.Reverse(i - 1, revCount);
                    tempRes = (j + 1) - i + 1;
                    res += tempRes;
                }


                writer.WriteLine("Case #{0}: {1}", testCase, res);
                writer.Flush();
            }

            writer.Close();
            reader.Close();
        }
    }
}
