using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record CustomCSS
(
    [property: JsonPropertyName("main")] Main? Main,
    [property: JsonPropertyName("banner")] Banner? Banner,
    [property: JsonPropertyName("content")] Content? Content,
    [property: JsonPropertyName("sidebar")] Sidebar? Sidebar
);
