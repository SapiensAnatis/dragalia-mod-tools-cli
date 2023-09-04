using System.Text.Json.Serialization;

namespace DragaliaModTools.SerializableDictionary;

public class ArrayObj<T>
{
    public T[] Array { get; set; } = System.Array.Empty<T>();

    public T this[int idx]
    {
        get => this.Array[idx];
        set => this.Array[idx] = value;
    }

    [JsonIgnore]
    public int Length => this.Array.Length;

    public static implicit operator T[](ArrayObj<T> obj) => obj.Array;

    [JsonConstructor]
    public ArrayObj() { }

    public ArrayObj(int size)
    {
        this.Array = new T[size];
    }
}
