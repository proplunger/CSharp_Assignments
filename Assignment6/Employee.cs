using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Employee
    {
        int empID;
        string name;
        string manager;
        public static int count = 0;

        virtual public void getDetails() {
            Console.WriteLine("Enter your id:");
            empID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter manager name:");
            manager = Console.ReadLine();
            count += 1;
        }

        virtual public void  displayDetails() {
            Console.WriteLine("ID is:"+empID);
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("Manager is:" + manager);
        }
    }
}
