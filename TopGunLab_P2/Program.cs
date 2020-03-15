using System;

namespace TopGunLab_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для поиска последовательности Фибоначчи");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Fibonacci.FibLoop(n);
            Console.WriteLine(result);
            Console.WriteLine("Фибоначчи рекурсией");
            result = Fibonacci.FibRec(n);
            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("Введите число для поиска факториала");
            n = Convert.ToInt32(Console.ReadLine());
            result = Factorial.FacLoop(n);
            Console.WriteLine(result);
            Console.WriteLine("Факториал рекурсией");
            result = Factorial.FacRec(n);
            Console.WriteLine(result);
        }   
    }
}
