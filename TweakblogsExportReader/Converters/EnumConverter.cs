using System.Text.Json;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Converters;

internal class EnumConverter<T> : JsonConverter<T?>
    where T : struct
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value == null
            ? null
            : Enum.TryParse<T>(value.Replace("-", string.Empty), true, out var result) ? result : throw new NotSupportedException($"'{value}' is not a supported {typeof(T).Name} value");
    }

    public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}