using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Banner
(
    [property: JsonPropertyName("bPicture")] Uri? Image,
    [property: JsonPropertyName("bFontFamily")] string? FontFamily,
    [property: JsonPropertyName("bFontSize")] uint? FontSize,
    [property: JsonPropertyName("bFontColor")] Color? FontColor,
    [property: JsonPropertyName("bWidth")] uint? Width,
    [property: JsonPropertyName("bHeight")] uint? Height,
    [property: JsonPropertyName("bShowTitle")] bool ShowTitle
);