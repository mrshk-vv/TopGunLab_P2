using System;
using System.Collections.Generic;
using System.Linq;

namespace TopGunLub_Task_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random r = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 10);
                Console.WriteLine(array[i]);
            }

            IEnumerable<IGrouping<int, int>> elements = array.GroupBy(i => i % 2);

            foreach (IGrouping<int,int> el in elements)
            {

                Console.WriteLine("Key = " + el.Key);

                foreach(int i in el)
                Console.WriteLine(i);
            }

        }
    }
}
