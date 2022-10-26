using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record CustomCSS
(
    [property: JsonPropertyName("main")] Main Main,
    [property: JsonPropertyName("banner")] Banner Banner,
    [property: JsonPropertyName("content")] Content Content
//TODO: What is this?
//object[] sidebar { get; set; } 
);
