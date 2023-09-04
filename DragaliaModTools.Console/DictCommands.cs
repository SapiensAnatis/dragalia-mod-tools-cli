using System.CommandLine;
using System.Text.Json;
using DragaliaModTools.SerializableDictionary;

namespace DragaliaModTools.Console;

public static class DictCommands
{
    public static Command DictCommand()
    {
        Command command =
            new("dict", description: "Operations for acting upon serializable dictionaries");

        command.AddCommand(AddItemCommand());

        return command;
    }

    static Command AddItemCommand()
    {
        Command command = new("add", "Add a key to a serialized dictionary");

        Argument<FileInfo> fileArgument =
            new("dict", description: "The filepath to the dictionary JSON file to operate on.");
        Argument<string> keyArgument = new("key", description: "The key to add.");

        command.AddArgument(fileArgument);
        command.AddArgument(keyArgument);
        command.SetHandler(
            (file, key) =>
            {
                if (!int.TryParse(key, out int keyInt))
                    throw new ArgumentException(nameof(key));

                SerializedDictAsset asset;
                using (FileStream fs = file.OpenRead())
                {
                    asset = JsonSerializer.Deserialize<SerializedDictAsset>(fs)!;
                }

                asset.Dict.Add(keyInt, new { property = "test" });

                System.Console.WriteLine(
                    JsonSerializer.Serialize(
                        asset,
                        new JsonSerializerOptions() { WriteIndented = true }
                    )
                );
            },
            fileArgument,
            keyArgument
        );

        return command;
    }

    static void AddItemHandler(FileInfo file, string key) { }
}
