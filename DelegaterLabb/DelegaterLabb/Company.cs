using System;
using System.Collections.Generic;
using System.Text;

namespace DelegaterLabb
{
    class Company
    {
        public string Name { get; set; }
        public int EmployeeCount { get; set; }

        public Company(string name, int employeeCount)
        {
            Name = name;
            EmployeeCount = employeeCount;
        }

    }
}
