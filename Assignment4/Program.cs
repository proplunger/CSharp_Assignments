// See https://aka.ms/new-console-template for more information
using Assignment;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml.Schema;

float total = 0;
char choice;
int pcode=0;
int qty;
int productQty=0;
int itemQty = 0;

Product[] products = new Product[6];
products[0] = new Product(1,"product1",100,.05f,200);
products[1] = new Product(2, "product2", 90, .03f, 300);
products[2] = new Product(3, "product3", 80, .04f, 400);
products[3] = new Product(4, "product4", 70, .06f, 500);
products[4] = new Product(5, "product5", 60, .05f, 100);
products[5] = new Product(6, "product6", 100, .02f, 2000);

Console.WriteLine("Enter your Name:");
string custName = Console.ReadLine();

Console.WriteLine("Enter your Address:");
string custAddr = Console.ReadLine();
Console.WriteLine("Enjoy shopping!");

while (true)
{
    Console.WriteLine("Enter product code(1-6):");
    pcode = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter quantity(<100):");
    qty = int.Parse(Console.ReadLine());
    total += products[pcode - 1].getProductTotal(qty);
    productQty += 1;
    itemQty += qty;
    Console.WriteLine("Want to purchase more?(Y/N)");
    choice = Convert.ToChar(Console.ReadLine());
    if (choice == 'N' || choice == 'n')
    {
        break;
    }
}
Console.WriteLine("----------Bill----------");
Console.WriteLine(DateTime.Now);
Console.WriteLine("Name: "+custName);
Console.WriteLine("Address: "+custAddr);
Console.WriteLine("Products: "+productQty);
Console.WriteLine("Total items: "+itemQty);
Console.WriteLine("Your Total is:{0}",total);


