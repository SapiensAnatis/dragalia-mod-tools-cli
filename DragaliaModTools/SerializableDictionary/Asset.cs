using System.Text.Json.Serialization;

namespace DragaliaModTools.SerializableDictionary;

public class Asset
{
    [JsonPropertyName("m_GameObject")]
    public object MGameObject { get; set; }

    [JsonPropertyName("m_Enabled")]
    public object MEnabled { get; set; }

    [JsonPropertyName("m_Name")]
    public object MName { get; set; }

    [JsonPropertyName("m_Script")]
    public object MScript { get; set; }
}
