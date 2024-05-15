using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer
{
    class FileExplorer(string folderPath)
    {
        private string folderPath = folderPath;

        public string GetFolderPath()
        {
            return folderPath;
        }

       // Search and Move .txt Files
        public void SearchForTextFiles(string folder)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] txtFiles = dir.GetFiles("*.txt", SearchOption.TopDirectoryOnly);

            if (txtFiles.Length > 0)
            {
                foreach (FileInfo file in txtFiles)
                {
                    File.Move($"{file}", $@"C:\\Users\\olomu\\Desktop\\FileProgramTest\\TextFiles\\{file.Name}");          
                }
                Console.WriteLine($"{txtFiles.Length} text files moved sucessfully");
            }
            else
            {
                Console.WriteLine("No *.txt files found");
            }
        }




        public void SearchForPDFFiles(string folder)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] txtFiles = dir.GetFiles("*.pdf", SearchOption.TopDirectoryOnly);
            Console.WriteLine($"Found {txtFiles.Length} *.pdf files\n");
        }

        public void SearchForMP3Files(string folder)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] txtFiles = dir.GetFiles("*.mp3", SearchOption.TopDirectoryOnly);
            Console.WriteLine($"Found {txtFiles.Length} *.mp3 files\n");
        }

        public void SearchForMP4Files(string folder)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] txtFiles = dir.GetFiles("*.mp4", SearchOption.TopDirectoryOnly);
            Console.WriteLine($"Found {txtFiles.Length} *.mp4 files\n");
        }


       
    }
}
