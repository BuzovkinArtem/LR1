using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class employee
    {
        public class Employee
        {
            public string FullName;
            public double Salary;

            public void Show()
            {
                Console.WriteLine($"ФИО:{FullName}");
                Console.WriteLine($"Зарплата:{Salary}");
            }

            public double CalculateAnnualSalary()
            {
                return Salary * 12;
            }
        }
    }
}

        