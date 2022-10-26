using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Converters;
internal class ColorConverter : JsonConverter<Color?>
{
    public override Color? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value == null ? null : ColorTranslator.FromHtml(value);
    }

    public override void Write(Utf8JsonWriter writer, Color? value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}
