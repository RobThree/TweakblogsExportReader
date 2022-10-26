using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Post
(
    [property: JsonPropertyName("url")] string URL,
    [property: JsonPropertyName("titel")] string Title,
    [property: JsonPropertyName("tekst")] string? ContentRML,
    [property: JsonPropertyName("teksthtml")] string? ContentHTML,
    [property: JsonPropertyName("publicatiedatum")] DateTimeOffset PublicationDate,
    [property: JsonPropertyName("laatstewijzigingsdatum")] DateTimeOffset LastModified,
    [property: JsonPropertyName("categorieën")] IEnumerable<string> Categories
);