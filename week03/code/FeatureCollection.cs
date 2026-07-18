using System.Text.Json.Serialization;
public class FeatureCollection
{
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; } = new();
}

public class Feature
{
    [JsonPropertyName("properties")]
    public EarthquakeProperties Properties { get; set; } = new();
}

public class EarthquakeProperties
{
    [JsonPropertyName("place")]
    public string Place { get; set; } = "";

    [JsonPropertyName("mag")]
    public double? Mag { get; set; }
}