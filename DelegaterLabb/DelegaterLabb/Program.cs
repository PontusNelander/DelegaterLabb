using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegaterLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>
            { 
                new Company("McDonalds",  42),
                new Company ("Murder King",23),
                new Company ("Gym Frossisten",2),
                new Company ("Dell", 1),
                
            };

            var result = companies.FindAll(HasOverTenEmployees);
            var result2 = companies.FindAll(c => c.EmployeeCount < 2);

            static bool HasOverTenEmployees(Company company) => company.EmployeeCount > 10;

            PrintOutToConsole(result);
            PrintOutToConsole(result2);

            
            
            
        }

        private static void PrintOutToConsole(List<Company> result)
        {
            foreach (var company in result)
            {
                Console.WriteLine($"Company Name: {company.Name} Employee Count: {company.EmployeeCount}");
            }
        }
    }
}
