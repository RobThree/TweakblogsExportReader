using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using TweakblogsExportReader.Models;

namespace TweakblogsExportReader.Converters;

/// <summary>
/// Used to handle PHP's insane serialization where it serializes empty "object" as [] instead of {}
/// </summary>
internal class CustomCSSJsonConverter : JsonConverter<CustomCSS>
{
    public override CustomCSS? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        return new CustomCSS(
            TryDeserialize<Main>(root, GetJsonName(c => c.Main), options),
            TryDeserialize<Banner>(root, GetJsonName(c => c.Banner), options),
            TryDeserialize<Content>(root, GetJsonName(c => c.Content), options),
            TryDeserialize<Sidebar>(root, GetJsonName(c => c.Sidebar), options)
        );
    }

    private string GetJsonName<T>(Expression<Func<CustomCSS, T>> property)
    {
        var propinfo = (property.Body as MemberExpression)?.Member as PropertyInfo;
        return propinfo != null
            ? propinfo.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? propinfo.Name
            : throw new InvalidOperationException("Expression is not a property");
    }

    private T? TryDeserialize<T>(JsonElement element, string property, JsonSerializerOptions options)
        where T : class
        => element.TryGetProperty(property, out var result) && result.ValueKind == JsonValueKind.Object
            ? result.Deserialize<T>(options)
            : null;

    public override void Write(Utf8JsonWriter writer, CustomCSS value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}