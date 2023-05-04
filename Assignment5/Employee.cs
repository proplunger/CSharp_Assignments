using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Employee
    {
        public int id;
        public string name;
        public string dept;
        public float salary;

        public Employee() { }

        public Employee(int id, string name, string dept, float salary) {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }

        public void displayDetails() {
            Console.WriteLine("ID is: "+id);
            Console.WriteLine("Name is: "+name);
            Console.WriteLine("Dept is: " + dept);
            Console.WriteLine("Salary is: " + salary);
        }
    }
}
