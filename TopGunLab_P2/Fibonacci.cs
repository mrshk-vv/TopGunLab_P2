using System;
using System.Collections.Generic;
using System.Text;

namespace TopGunLab_P2
{
    public class Fibonacci
    {
        public static int FibLoop(int n)
        {
            Console.WriteLine("Фибоначчи циклом");
            int a = 0;
            int b = 1;
            int k = 2;
            int buffer;

            while (k != n)
            {
                buffer = a;
                a = b;
                b = a + buffer;
                k++;
            }
            return b;
        }

        //Фибоначи рекурсией
        public static int FibRec(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return FibRec(n - 1) + FibRec(n - 2);
        }
    }
}
