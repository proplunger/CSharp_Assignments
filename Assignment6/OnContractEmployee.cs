using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class OnContractEmployee:Employee
    {
        float duration;
        double charges;
        DateTime contractDate;

        override public void getDetails() {
            base.getDetails();
            Console.WriteLine("Enter contract date:");
            contractDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter duration:");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter charges:");
            charges = float.Parse(Console.ReadLine());
        }

        override public void displayDetails() { 
        base.displayDetails();
            Console.WriteLine("Contract Date: " + contractDate);
            Console.WriteLine("Contract Duration: "+duration);
            Console.WriteLine("Charges:"+charges);
            Console.WriteLine("Net Salary:"+(duration*charges));
;        }
    }
}
