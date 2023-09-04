using System.Text.Json.Serialization;

namespace DragaliaModTools.SerializableDictionary;

public class SerializedDictAsset : Asset
{
    [JsonPropertyName("dict")]
    public IntSerializableDictionary Dict { get; set; }
}
