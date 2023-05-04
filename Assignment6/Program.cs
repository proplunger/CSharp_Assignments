namespace Assignment6
{
    internal class Program
    {
        static void Main()
        {
            char ch;
            Console.WriteLine("Enter type of Employment:\n p:on payroll\nc:on contract");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'p')
            {
                OnPayrollEmployee pemp = new OnPayrollEmployee();
                pemp.getDetails();
                pemp.displayDetails();
            }
            else if (ch == 'c')
            {
                OnContractEmployee cemp = new OnContractEmployee();
                cemp.getDetails();
                cemp.displayDetails();
            }
            else {
                Console.WriteLine("Wrong input");
            }
        }
    }
}