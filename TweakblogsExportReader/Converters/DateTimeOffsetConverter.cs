using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Converters;
internal class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    private const string _expectedformat = "yyyy-M-d H:m:s";
    private static readonly TimeZoneInfo _defaultoriginatingtimezone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
    private static readonly IFormatProvider _defaultformatprovider = CultureInfo.InvariantCulture;
    private readonly IFormatProvider _formatprovider;
    private readonly TimeZoneInfo _originatingtimezone;

    public DateTimeOffsetConverter(IFormatProvider? formatprovider = null, TimeZoneInfo? originatingTimezone = null)
    {
        _formatprovider = formatprovider ?? _defaultformatprovider;
        _originatingtimezone = originatingTimezone ?? _defaultoriginatingtimezone;
    }

    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var datetime = DateTime.ParseExact(reader.GetString(), _expectedformat, _formatprovider, DateTimeStyles.None);
        return new DateTimeOffset(datetime, _originatingtimezone.GetUtcOffset(datetime));
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}