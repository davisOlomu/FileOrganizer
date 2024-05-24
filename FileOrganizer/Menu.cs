using Spectre.Console;

namespace FileOrganizer
{
    /// <summary>
    /// 
    /// </summary>
    internal class Menu
    {    
        public static void MainMenu()
        {
            var fileMenu = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("File [green]Organizer[/]")
        .PageSize(10)
        .AddChoices(new[] {
            "Organize Files",
           "Settings", 
            "Exit",          
        }));

            if (fileMenu.Contains("Organize Files"))
            {
                Console.Write("Enter folder path:  ");
                string folder = Console.ReadLine();
                Console.Clear();
                DirectoryExplorer.CreateSubDirectories(folder);
                FileExplorer xplorer = new FileExplorer(folder);
                xplorer.SortFileTypes();
            }
            else if (fileMenu.Contains("Settings"))
            {
                Console.WriteLine("settings");
            }
            else if (fileMenu.Contains("Exit"))
            {
                Console.WriteLine("exit");
            }
        }
    }
}
