using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("height")]
    public int Height { get; set; }   // vem em decímetros

    [JsonPropertyName("weight")]
    public int Weight { get; set; }   // vem em hectogramas

    [JsonPropertyName("sprites")]
    public Sprites Sprites { get; set; } = new();
}

public class Sprites
{
    [JsonPropertyName("other")]
    public Other Other { get; set; } = new();
}

public class Other
{
    [JsonPropertyName("official-artwork")]
    public OfficialArtwork OfficialArtwork { get; set; } = new();
}

public class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}