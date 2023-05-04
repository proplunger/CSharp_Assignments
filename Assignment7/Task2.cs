using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Task2
    {
        static string BASE_PATH = @"C:\Users\Karan.Rautela\Documents";

        public static void CreateFile()
        {
            FileStream fs = new FileStream(BASE_PATH + @"\demofile.txt", FileMode.CreateNew);
            Console.WriteLine("File created successfully.");
            fs.Close();
        }

        public static void AddContent()
        {
            FileStream fs = new FileStream(BASE_PATH + @"\demofile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("This is content of new file.");
            writer.WriteLine("Adding more content..");
            writer.Close();
            fs.Close();
        }

        public static void AppendContent()
        {
            FileStream fs = new FileStream(BASE_PATH + @"\demofile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Appending content to existing content.");
            writer.WriteLine("Appending more content..");
            writer.Close();
            fs.Close();
        }

        public static void DisplayContentOneByOne()
        {
            FileStream fs = new FileStream(BASE_PATH + @"\demofile.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            while (reader.Peek() > -1)
            {
                Console.Write((char)reader.Read());
            }
            reader.Close();
            fs.Close();
        }

        public static void DisplayAllContent()
        {
            FileStream fs = new FileStream(BASE_PATH + @"\demofile.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
            fs.Close();
        }
    }
}
