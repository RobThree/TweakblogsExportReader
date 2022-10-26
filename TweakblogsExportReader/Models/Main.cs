using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Main
(
    [property: JsonPropertyName("bgColor")] string? BackgroundColor,
    [property: JsonPropertyName("bgPicture")] string? BackgroundImage,
    [property: JsonPropertyName("bgRepeat")] string? BackgroundRepeat,
    [property: JsonPropertyName("bgAttachment")] string? BackgroundAttachment,
    [property: JsonPropertyName("pageBorderColor")] string? PageBorderColor,
    [property: JsonPropertyName("pageBorderSize")] int? PageBorderSize,
    [property: JsonPropertyName("pageBgColor")] string? PageBackgroundColor,
    [property: JsonPropertyName("linkColor")] string? LinkColor,
    [property: JsonPropertyName("linkTextDecoration")] string? LinkTextDecoration,
    [property: JsonPropertyName("linkHoverColor")] string? LinkHoverColor,
    [property: JsonPropertyName("linkHoverTextDecoration")] string? LinkHoverTextDecoration,
    [property: JsonPropertyName("linkVisitedColor")] string? LinkVisitedColor,
    [property: JsonPropertyName("linkVisitedTextDecoration")] string? LinkVisitedTextDecoration
);