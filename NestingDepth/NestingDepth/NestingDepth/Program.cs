using System;
using System.IO;
using System.Text;

public class Template
{

    public static void Main()
    {
        TextReader reader = System.Console.In;
        TextWriter writer = System.Console.Out;
        try
        {
            int NOP = 0;
            String CloseParanthesis = ")";
            String OpenParanthesis = "(";
            StringBuilder sb = new StringBuilder();

            int testCases = int.Parse(reader.ReadLine());
            for (int testCase = 1; testCase <= testCases; testCase++)
            {

                String input = reader.ReadLine().ToString();
                foreach (var item in input)
                {
                    int Digit = 0;
                    int.TryParse(item.ToString(), out Digit);
                    if (Digit == 0)
                    {
                        sb.Insert(sb.Length, CloseParanthesis, NOP).Append(Digit);
                        NOP = 0;
                    }
                    else if (NOP == Digit)
                    {
                        sb.Append(Digit);
                    }
                    else if (NOP > Digit)
                    {
                        int NCP = NOP - Digit;
                        NOP -= NCP;
                        sb.Insert(sb.Length, CloseParanthesis, NCP).Append(Digit);
                    }
                    else if (NOP < Digit)
                    {
                        int tempNOP = Digit - NOP;
                        NOP += tempNOP;
                        sb.Insert(sb.Length, OpenParanthesis, tempNOP).Append(Digit);
                    }
                }
                writer.WriteLine("Case #{0}: {1}", testCase, sb.Insert(sb.Length, CloseParanthesis, NOP).ToString());
                writer.Flush();
                NOP = 0;
                sb = new StringBuilder();
            }

            writer.Close();
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            writer.WriteLine(ex.ToString());
            throw ex;
        }

    }
}