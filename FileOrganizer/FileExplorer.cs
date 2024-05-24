using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="folderPath"></param>
    class FileExplorer(string folderPath)
    {
        private string folderPath = folderPath;

        public string GetFolderPath()
        {
            return folderPath;
        }


        private void SearchAndMoveFiles(string currentFolder, string newfolder, string fileType)
        {
            DirectoryInfo dir = new DirectoryInfo(currentFolder);
            FileInfo[] files = dir.GetFiles(fileType, SearchOption.TopDirectoryOnly);
            if (files.Length > 0)
            {
                foreach (FileInfo file in files)
                {
                    string movePath = Path.Combine(currentFolder, newfolder, file.Name);
                    File.Move($"{file}",movePath);
               

                    string logPath = Path.Combine(currentFolder, "LogFile.txt");
                    FileLogger newLog = new (logPath);
                    newLog.LogMovement(currentFolder, newfolder, file.Name, file.Length);
                }
                Notification.MoveFiles(files.Length, fileType);
                Notification.WriteToLog(files.Length, fileType);
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
