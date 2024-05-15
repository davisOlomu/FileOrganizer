using System;
using System.IO;


namespace FileOrganizer
{
    internal class Program
    { 
        static void Main()
        {
        
            FileExplorer newFile = new FileExplorer($@"C:\\Users\\olomu\\Desktop\\FileProgramTest");
         //   DirectoryExplorer.CreateDirectories(newFile.GetFolderPath());
            newFile.SearchForTextFiles(newFile.GetFolderPath());

            Console.ReadLine();
        }    
    }
}
