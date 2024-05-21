using System;
using System.IO;


namespace FileOrganizer
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter folder path: ");
            string folder = $@"C:\\Users\\olomu\\Desktop\\FileProgramTest";
            DirectoryExplorer.CreateSubDirectories(folder);
            FileExplorer xplorer = new FileExplorer(folder);
            xplorer.SortFileTypes();

            Console.ReadLine();
        }
    }
}
