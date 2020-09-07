using System;
using static System.Console;
using System.IO;

namespace Mylist
{

    class Program
    {   
         static void list_print(string path)
         {
           
            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] files = d.GetFiles();
            DirectoryInfo[]directories = d.GetDirectories();
            foreach(FileInfo f in files)
            {
                WriteLine(f.Name);
            }
            foreach(DirectoryInfo i in directories)
            {
                
                WriteLine(i.Name);
            }
         }
        static void creat_folder(string path,string folderName)
        {
            string pathString = System.IO.Path.Combine(path,folderName);
            System.IO.Directory.CreateDirectory(pathString);
            // string filePath = System.IO.Path.Combine(pathString, "hello.txt");
            // System.IO.File.Create(filePath);
        }
        static void delete(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
        }
        static void Main(string[] args)
        {
            list_print(args[0]);
            ReadKey();
        }
    }
}
