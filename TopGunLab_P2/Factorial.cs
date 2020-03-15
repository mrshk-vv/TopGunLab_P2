using System;
using System.Collections.Generic;
using System.Text;

namespace TopGunLab_P2
{
    public class Factorial
    {
        //Факториал циклом
        public static int FacLoop(int n)
        {
            Console.WriteLine("Факториал циклом");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        //Факториал рекурсией
        public static int FacRec(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return FacRec(n - 1) * n;
            }
        }
    }
}
