// See https://aka.ms/new-console-template for more information

using System.CommandLine;

namespace DragaliaModTools.Console;

class Program
{
    static async Task<int> Main(string[] args)
    {
        RootCommand rootCommand = new("Tools to operate on Dragalia Lost assets");
        rootCommand.AddCommand(DictCommands.DictCommand());

        return await rootCommand.InvokeAsync(args);
    }
}
