using System.Text.Json.Serialization;

namespace DragaliaModTools.SerializableDictionary;

public class StringSerializableDictionary<TObject> : SerializableDictionary<string, TObject>
{
    [JsonIgnore]
    public override IEqualityComparer<string> Comparer => MonoStringEqualityComparer.Instance;

    [JsonConstructor]
    public StringSerializableDictionary()
        : base() { }
}
