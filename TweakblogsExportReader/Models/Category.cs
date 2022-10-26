using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Category
(
    [property: JsonPropertyName("categorienaam")] string Name,
    [property: JsonPropertyName("beschrijving")] string? Description,
    [property: JsonPropertyName("hoofdcategorie")] string? ParentCategory
);