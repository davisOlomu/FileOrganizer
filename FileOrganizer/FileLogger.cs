using System.Text;

namespace FileOrganizer
{
    /// <summary>
    /// 
    /// </summary>
    internal class FileLogger
    {
        private readonly string _logFilePath;

        public FileLogger(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        public void LogMovement(string sourcePath, string destinationPath, string fileName, long filesize)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine($"Filename: {fileName}");
            message.AppendLine($"Filesize: {filesize.ToString()}");
            message.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss} - Moved: {sourcePath} -> {destinationPath}");
            WriteLogLine(message.ToString());
        }

        
        private void WriteLogLine(string message)
        {
            using StreamWriter writer = File.AppendText(_logFilePath);
            writer.WriteLine(message);
        }
    }
}
