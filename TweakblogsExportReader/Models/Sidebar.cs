using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Sidebar
(
    [property: JsonPropertyName("sbBgColor")] Color? BackgroundColor,
    [property: JsonPropertyName("sbFontFamily")] string? FontFamily,
    [property: JsonPropertyName("sbFontSize")] byte FontSize,
    [property: JsonPropertyName("sbFontColor")] Color? FontColor,
    [property: JsonPropertyName("sbFontWeight")] FontWeight? FontWeight,
    [property: JsonPropertyName("sbFontStyle")] FontStyle? FontStyle,
    [property: JsonPropertyName("sbTextDecoration")] TextDecoration? TextDecoration,
    [property: JsonPropertyName("sbH4FontFamily")] string? H4FontFamily,
    [property: JsonPropertyName("sbH4FontSize")] byte H4FontSize,
    [property: JsonPropertyName("sbH4FontColor")] Color? H4FontColor,
    [property: JsonPropertyName("sbH4FontWeight")] FontWeight? H4FontWeight,
    [property: JsonPropertyName("sbH4FontStyle")] FontStyle? H4FontStyle,
    [property: JsonPropertyName("sbH4TextDecoration")] TextDecoration? H4TextDecoration
);
