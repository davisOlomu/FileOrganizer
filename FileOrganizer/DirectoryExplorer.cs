using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer
{
    internal class DirectoryExplorer
    {
        public static void CreateDirectories(string folder)
        {
     
            DirectoryInfo txtDirectory = new(folder);
            txtDirectory.CreateSubdirectory("TextFiles");

            DirectoryInfo pdfDirectory = new(folder);
            pdfDirectory.CreateSubdirectory("PdfFiles");

            DirectoryInfo mp3Directory = new(folder);
            mp3Directory.CreateSubdirectory("MP3Files");

            DirectoryInfo mp4Directory = new(folder);
            mp4Directory.CreateSubdirectory("MP4Files");
        }
    }
}
