using Spectre.Console;

namespace FileOrganizer
{
    /// <summary>
    /// 
    /// </summary>
    internal class Notification
    {
        public static void MoveFiles(long fileLength, string filetype)
        {
            AnsiConsole.Status()
                .AutoRefresh(true)
                .Spinner(Spinner.Known.Star)
                .SpinnerStyle(Style.Parse("green bold"))
                .Start("Moving files...", ctx =>
                {
                    ctx.Spinner(Spinner.Known.Star);
                    ctx.SpinnerStyle(Style.Parse("green"));
                    Thread.Sleep(5000);
                    AnsiConsole.MarkupLine($"[green]{fileLength}[/] [yellow]{filetype} [/][grey]file(s) moved sucessfully[/]");
                });
        }

        public static void WriteToLog(long fileLength, string filetype)
        {
            AnsiConsole.Status()
                .AutoRefresh(true)
                .Spinner(Spinner.Known.Star)
                .SpinnerStyle(Style.Parse("green bold"))
                .Start("LOG...", ctx =>
                {
                    ctx.Spinner(Spinner.Known.Star);
                    ctx.SpinnerStyle(Style.Parse("green"));
                    Thread.Sleep(5000);
                    AnsiConsole.MarkupLine($"[red]{fileLength}[/] [green]{filetype}[/][grey] file(s) logged sucessfully[/]");
                });
        }
    }
}
