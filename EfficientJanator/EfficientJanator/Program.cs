using System;

namespace EfficientJanator
{
    public static class EfficientJanatorClass
    {
        public static void Main()
        {
            int numPlasticBag = 0;
            decimal sum = 0, count = 0;
            int.TryParse(Console.ReadLine(), out numPlasticBag);
            for (int i = 0; i < numPlasticBag; i++)
            {
                decimal weight = (decimal)0.00;
                decimal.TryParse(Console.ReadLine(), out weight);
                sum += weight;
                if (sum == (decimal)3.0)
                {
                    count++;
                    sum = 0;
                }
                else if (sum > (decimal)3.0)
                {
                    count++;
                    sum = weight;
                }
            }
            if (sum > 0)
                count++;
            Console.WriteLine(count);
        }
    }

}