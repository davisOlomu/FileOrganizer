using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOrganizer
{
    internal class DirectoryExplorer
    {
        public static void CreateSubDirectories(string currentFolder)
        {

            Dictionary<string, string> fileExtension = new Dictionary<string, string>()
             {
                { ".txt", "TextFiles"},
                { ".pdf", "PDFFiles" },
                { ".mp3", "MP3Files" },
                { ".mp4", "MP4Files" }
             };

            DirectoryInfo dir = new DirectoryInfo(currentFolder);
            FileInfo[] files = dir.GetFiles();

            foreach (var file in files)
            {
                if (fileExtension.ContainsKey(file.Extension))
                {
                    string subdirectoryName = fileExtension[file.Extension];
                    string targetPath = Path.Combine(currentFolder, subdirectoryName);

                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }
                }
            }
        }
    }
}
