using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 1;
            int v2 = 2;
            int v3 = v1 + v2;
            int sum = 2;

            while(v3 < 4000000)
            {
                if (v3 % 2 == 0)
                    sum += v3;

                v1 = v2;
                v2 = v3;
                v3 = v1 + v2;
            }

            Console.WriteLine(sum.ToString());
            Console.ReadKey();

        }
    }
}
