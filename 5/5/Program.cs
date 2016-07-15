using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0, i = 0;
            bool verifier = true, verifier2 = true;
            while (verifier)
            {
                verifier2 = true;
                value ++;
                i = 0;
                do
                {
                    i++;
                    if (value % i != 0)
                        verifier2 = false;
                    if (i == 20 && verifier2 == true)
                    {
                        verifier2 = false;
                        verifier = false;
                    }
                    
                } while (verifier2 == true || i <= 20);                               
            }
            Console.WriteLine(value.ToString());
            Console.ReadKey();
        }
    }
}
