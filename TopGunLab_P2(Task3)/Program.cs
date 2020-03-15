using System;
using System.Linq;
using System.Collections.Generic;
using TopGunLab_P2_Task3_.Models;

namespace TopGunLab_P2_Task3_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "Ruslan",
                    Surname = "Dudchenko",
                    Company = "FalseChel"
                },

                new Employee
                {
                    Id = 2,
                    Name = "Vova",
                    Surname = "Murashko",
                    Company = "TrueChel"

                },

                new Employee
                {
                    Id = 3,
                    Name = "Vitalik",
                    Surname = "Basanec",
                    Company = "TrueChel"
                },

                new Employee
                {
                    Id = 4,
                    Name = "Andrei",
                    Surname = "Chernenko",
                    Company = "TrueChel"

                }
            };


            var SortedEmployees = employees.GroupBy(i => i.Company);
            foreach (IGrouping<string, Employee> e in SortedEmployees)
            {
                Console.WriteLine(e.Key);
                foreach (var t in e)
                    Console.WriteLine(t.Name);
                Console.WriteLine();
            }
        }
    }
}
