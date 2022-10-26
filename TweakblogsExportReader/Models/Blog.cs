using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Blog
(
    [property: JsonPropertyName("blognaam")] string Name,
    [property: JsonPropertyName("titel")] string? Title,
    [property: JsonPropertyName("ondertitel")] string? SubTitle,
    [property: JsonPropertyName("beschrijving")] string? DescriptionRML,
    [property: JsonPropertyName("beschrijvinghtml")] string? DescriptionHTML,
    [property: JsonPropertyName("customCss")] CustomCSS CustomCSS,
    [property: JsonPropertyName("ingangsdatum")] DateTimeOffset StartDate,
    [property: JsonPropertyName("laatstewijzigingsdatum")] DateTimeOffset LastModified,
    [property: JsonPropertyName("categorieën")] IEnumerable<Category> Categories,
    [property: JsonPropertyName("posts")] IEnumerable<Post> Posts
);
