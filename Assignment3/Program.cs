using System.ComponentModel;
//using Assignmentdll;

namespace Assignment1
{
    internal class Program
    {
        static void arithOperations(int num1, int num2) {
            Console.WriteLine("The sum of two numbers is: {0}", num1 + num2);
            Console.WriteLine("The difference of two numbers is: {0}", num1 - num2);
            Console.WriteLine("The quotient is: {0}", num1 / num2);
        }

        static void operationsByChoice() {
            Console.WriteLine("Enter number1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Choice:\n1 for Addition\n2 for Subtarction\n3 for Quotient");
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.WriteLine($"Sum of two Numbers is:{num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Difference of two numbers is:{ num1-num2}");
                    break;
                case 3:
                    Console.WriteLine($"Quotient is:{num1/num2}");
                    break;
                default:
                    Console.WriteLine("Wrong Input.");
                    break;
            }
        }

        static void displayHello() {
            Console.WriteLine("Hello!");
        }

        static void displayName() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Karan Singh Rautela");
            }
        }

        static void displayEven() {
            for (int i = 1; i <= 10; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        static void dispalyOdd() {
            for (int i = 50; i >= 7; i--) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

        static void displayTable(int num) {
            for (int i=1;i<=10;i++) {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }

        static void displayRange() {
            for (int i = 100; i >= 5; i -= 3) {
                Console.WriteLine(i);
            }
        }

        static void displayOneLine() {
            int num1 = 4;
            int num2 = 3;
            int num3 = 6;
            Console.WriteLine($"Number1:{num1}  Number2:{num2}  Number3:{num3}");
        }

        static void dispalySeparateLine() {
            int num1 = 9;
            int num2 = 8;
            int num3 = 2;

            Console.WriteLine($"Number1:{num1}\nNumber2:{num2}\nNumber3:{num3}");
        }
        static void Main()
        {
            //displayHello();
            //displayName();  
            //arithOperations(1, 2);
            //displayEven();
            //dispalyOdd();   
            //displayTable(4);
            //displayRange();
            //displayOneLine();
            //dispalySeparateLine();
            //operationsByChoice();
            //Console.WriteLine(NumericFunctions.Add(1,2,3,4,5));
            //Console.WriteLine(NumericFunctions.Subtract(12,2));
        }
    }
}