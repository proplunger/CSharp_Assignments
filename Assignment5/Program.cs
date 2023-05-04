using System.Collections.Generic;
namespace Assignment5;

internal class Program
{
    static void Main()
    {
        List<Employee> list = new List<Employee>();
        list.Add(new Employee(1, "karan", "HR", 12000));
        list.Add(new Employee(2, "sam", "Tech", 10000));
        list.Add(new Employee(3, "kan", "Acc", 140000));
        list.Add(new Employee(4, "ran", "HR", 1200));
        list.Add(new Employee(5, "aan", "Acc", 11200));
        list.Add(new Employee(6, "kaa", "Tech", 24000));
        list.Add(new Employee(7, " an", "HR", 26000));
        list.Add(new Employee(8, "aslo", "Tech", 27000));
        list.Add(new Employee(9, "nsui", "HR", 11000));

        //var recordSalary = from Employee emp in list where emp.salary > 10000 && emp.salary < 25000 select emp;
        var recordSalary = list.Where(x=> x.salary>10000 && x.salary<25000).ToList();
        foreach (Employee emp in recordSalary)
        {
            //emp.displayDetails();
        }

        //var recordHR = from Employee emp in list where emp.dept == "HR" select emp;
        var recordHR = list.Where(x=> x.dept=="HR").ToList();
        //var recordHR = list.Where(x=> x.dept.Contains("HR")).ToList();

        foreach (Employee emp in recordHR)
        {
            emp.displayDetails();
        }

        var record = from Employee emp in list select emp;
        foreach (Employee emp in record)
        {
            //emp.displayDetails();
        }

        foreach (Employee emp in list)
        {
            //Console.WriteLine("ID is: " + emp.id);
            //Console.WriteLine("Name is: " + emp.name);
        }

        var recordSalaryAccount = from Employee emp in list where emp.salary > 12000 && emp.dept == "Acc" select emp;
        foreach (Employee emp in record)
        {
            //emp.displayDetails();
        }
    }
}