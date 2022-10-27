using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Banner
(
    [property: JsonPropertyName("bPicture")] Uri? Image,
    [property: JsonPropertyName("bFontFamily")] string? FontFamily,
    [property: JsonPropertyName("bFontSize")] byte FontSize,
    [property: JsonPropertyName("bFontColor")] Color? FontColor,
    [property: JsonPropertyName("bWidth")] byte Width,
    [property: JsonPropertyName("bHeight")] byte Height,
    [property: JsonPropertyName("bShowTitle")] bool ShowTitle
);