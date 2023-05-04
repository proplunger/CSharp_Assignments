using System.IO;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.CreateDirectory();
            Task1.CreateFiles();
            Task1.WriteFile();
            Task1.CopyFile();
            Task1.GetFiles();
            Task1.GetDirectories();
            Task1.DeleteDirectory();

            Task2.CreateFile();
            Task2.AddContent();
            Task2.AppendContent();
            Task2.DisplayContentOneByOne();
            Task2.DisplayAllContent();

        }
    }
}
