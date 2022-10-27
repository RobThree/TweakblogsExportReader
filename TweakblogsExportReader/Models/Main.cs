using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Main
(
    [property: JsonPropertyName("bgColor")] Color? BackgroundColor,
    [property: JsonPropertyName("bgPicture")] Uri? BackgroundImage,
    [property: JsonPropertyName("bgRepeat")] Repeat? BackgroundRepeat,
    [property: JsonPropertyName("bgAttachment")] Attachment? BackgroundAttachment,
    [property: JsonPropertyName("pageBorderColor")] Color? PageBorderColor,
    [property: JsonPropertyName("pageBorderSize")] byte PageBorderSize,
    [property: JsonPropertyName("pageBgColor")] Color? PageBackgroundColor,
    [property: JsonPropertyName("linkColor")] Color? LinkColor,
    [property: JsonPropertyName("linkTextDecoration")] TextDecoration? LinkTextDecoration,
    [property: JsonPropertyName("linkHoverColor")] Color? LinkHoverColor,
    [property: JsonPropertyName("linkHoverTextDecoration")] TextDecoration? LinkHoverTextDecoration,
    [property: JsonPropertyName("linkVisitedColor")] Color? LinkVisitedColor,
    [property: JsonPropertyName("linkVisitedTextDecoration")] TextDecoration? LinkVisitedTextDecoration
);
