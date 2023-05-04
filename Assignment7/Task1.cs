using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Task1
    {
        static string BASE_PATH = @"C:\Users\Karan.Rautela\Documents";
        public static void CreateDirectory() {
            if (!Directory.Exists(BASE_PATH + @"\demo"))
            {
                Directory.CreateDirectory(BASE_PATH + @"\demo");
            }
            if (!Directory.Exists(BASE_PATH + @"\demo\demo1"))
            {
                Directory.CreateDirectory(BASE_PATH + @"\demo\demo1");
            }
            if (!Directory.Exists(BASE_PATH + @"\demo\demo2"))
            {
                Directory.CreateDirectory(BASE_PATH + @"\demo\demo2");
            }
        }

        public static void CreateFiles() {

            if (!File.Exists(BASE_PATH + @"\demo\newfile.txt"))
            {
                File.Create(BASE_PATH + @"\demo\newfile.txt");
            }
            if (!File.Exists(BASE_PATH + @"\demo\newfile1.docx"))
            {
                File.Create(BASE_PATH + @"\demo\newfile1.docx");
            }
            if (!File.Exists(BASE_PATH + @"\demo\newfile2.py"))
            {
                File.Create(BASE_PATH + @"\demo\newfile2.py");
            }
            if (!File.Exists(BASE_PATH + @"\demo\newfile3.txt"))
            {
                FileInfo fi = new FileInfo(BASE_PATH + @"\demo\newfile3.txt");
                fi.Create();
            }
        }

        public static void WriteFile() {

            FileStream fs = new FileStream(BASE_PATH + @"\demo\newfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Hello World");
            writer.Close();
            fs.Close();
        }

        public static void CopyFile() {
            //File.Copy(BASE_PATH + @"\demo\newfile.txt", BASE_PATH + @"\demo\demo2\newfilecopy.txt");
        }
        public static void GetFiles() {

            string[] fileEntries = Directory.GetFiles(BASE_PATH + @"\demo");
            foreach (string fileName in fileEntries)
            {
                Console.WriteLine(fileName);
                Console.WriteLine(File.GetCreationTime(fileName).ToString());
            }
        }

        public static void GetDirectories()
        {
            string[] subdirectoryEntries = Directory.GetDirectories(BASE_PATH + @"\demo");
            foreach (string subdirectory in subdirectoryEntries)
            {
                Console.WriteLine((subdirectory));
            }
        }

        public static void DeleteDirectory()
        {
            Directory.Delete(BASE_PATH + @"\demo", true);
        }
    }
}
