using System;
using System.Collections.Generic;

namespace DelegaterLabb
{
    class Program
    {
        static List<Company> companies = new List<Company>
        {
            new Company("Bonnier", 467),
            new Company("Swedbank", 1230),
            new Company("Abbes Grill", 1),
            new Company("Arkitektbyrån AB", 15),
        };

        static void Main(string[] args)
        {
            var result = companies.FindAll(HasOverTenEmployees);

            Console.WriteLine("Fler än 10:");
            foreach (var c in result)
            {
                Console.WriteLine($"{c.Name}, {c.EmployeeCount}");
            }

            Console.WriteLine();

            var result2 = companies.FindAll(c => c.EmployeeCount < 2);

            Console.WriteLine("Färre än två:");
            foreach (var c in result2)
            {
                Console.WriteLine($"{c.Name}, {c.EmployeeCount}");
            }
        }

        private static bool HasOverTenEmployees(Company c) => c.EmployeeCount > 10;
        
    }
}
