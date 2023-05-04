using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class OnPayrollEmployee:Employee
    {
        DateTime joiningDate;
        float exp;
        float baseSalary;
        float da;
        float hra;
        float netSalary;
        float pf;

        override public void  getDetails() {
            base.getDetails();
            Console.WriteLine("Enter joining date:");
            joiningDate = Convert.ToDateTime((Console.ReadLine()));
            Console.WriteLine("Enter your Experience:");
            exp = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your base salary:");
            baseSalary = float.Parse(Console.ReadLine());
        }

        override public void displayDetails() {
            base.displayDetails();
            Console.WriteLine("Joining Date: "+joiningDate);
            Console.WriteLine("Experience: " + exp);
            Console.WriteLine("NetSalary: " + calculateSalary());
            Console.WriteLine("da: " + da);
            Console.WriteLine("hra: " + hra);
            Console.WriteLine("pf: " + pf);
        }

         float calculateSalary() {
            if (exp > 10)
            {
                da = 0.1f * baseSalary;
                hra = 0.085f * baseSalary;
                pf = 6200;
                netSalary = baseSalary + da + hra  - pf;
            }
            else if (exp > 7 && exp < 10)
            {
                da = 0.07f * baseSalary;
                hra = 0.065f * baseSalary;
                pf = 4100;
                netSalary = baseSalary + da + hra - pf;
            }
            else if (exp > 5 && exp < 7)
            {
                da = 0.041f * baseSalary;
                hra = 0.038f * baseSalary;
                pf = 1800;
                netSalary = baseSalary + da + hra - pf;
            }
            else {
                da = 0.019f * baseSalary;
                hra = 0.02f * baseSalary;
                pf = 1200;
                netSalary = baseSalary + da + hra - pf;
            }
            return netSalary;
        }
    }
}
