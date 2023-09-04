using System.Text.Json.Serialization;

namespace DragaliaModTools.SerializableDictionary;

public class IntSerializableDictionary : SerializableDictionary<int, object>
{
    [JsonConstructor]
    public IntSerializableDictionary()
        : base() { }
}
