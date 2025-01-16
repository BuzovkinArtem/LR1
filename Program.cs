using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LR1.employee;

namespace LR1
{
    internal class Program

    {

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FullName ="Иванов";
            employee.Salary =63500;

            employee.Show();

            double annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine($"Годовой размер зарплаты = {annualSalary}");
        }
    }
}


