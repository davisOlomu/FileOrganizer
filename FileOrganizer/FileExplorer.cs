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

        // Find specific file types and move
        // to corresponding folder
        public void SearchAndMoveFiles(string currentFolder, string newfolder, string fileType)
        {
            DirectoryInfo dir = new DirectoryInfo(currentFolder);
            FileInfo[] files = dir.GetFiles(fileType, SearchOption.TopDirectoryOnly);
            if (files.Length > 0)
            {
                foreach (FileInfo file in files)
                {
                    File.Move($"{file}",$@"{currentFolder}\\{newfolder}\\{file.Name}");
                }
                Console.WriteLine($"{files.Length} {fileType} file(s) moved sucessfully");
            }
            else
            {
                Console.WriteLine($"No {fileType} files found!");
            }
        }


        // Sort files by the file type extension
        public void SortFileTypes()
        {
            SearchAndMoveFiles(folderPath, "TextFiles", "*.txt");
            SearchAndMoveFiles(folderPath, "MP3Files", "*.mp3");
            SearchAndMoveFiles(folderPath, "MP4Files", "*.mp4");
            SearchAndMoveFiles(folderPath, "PdfFiles", "*.pdf");
        }
    }
}
