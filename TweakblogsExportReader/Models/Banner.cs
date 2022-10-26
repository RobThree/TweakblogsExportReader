using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Banner
(
    [property: JsonPropertyName("bPicture")] string? Image,
    [property: JsonPropertyName("bFontFamily")] string? FontFamily,
    [property: JsonPropertyName("bFontSize")] int? FontSize,
    [property: JsonPropertyName("bFontColor")] string? FontColor,
    [property: JsonPropertyName("bWidth")] int? Width,
    [property: JsonPropertyName("bHeight")] int? Height,
    [property: JsonPropertyName("bShowTitle")] bool ShowTitle
);