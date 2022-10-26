using System.Text.Json;
using TweakblogsExportReader.Converters;
using TweakblogsExportReader.Models;

namespace TweakblogsExportReader;
public class TweakblogsExportJsonReader
{
    private readonly JsonSerializerOptions _defaultjsonserializeroptions = new()
    {
        Converters = { new DateTimeOffsetConverter() }
    };

    private readonly JsonSerializerOptions _jsonserializeroptions;

    public TweakblogsExportJsonReader(JsonSerializerOptions? jsonserializeroptions = null)
        => _jsonserializeroptions = jsonserializeroptions ?? _defaultjsonserializeroptions;

    public async ValueTask<Blog> ReadAsync(string path, CancellationToken cancellationToken = default)
    {
        using var f = File.OpenRead(path);
        return (await JsonSerializer.DeserializeAsync<Blog>(f, _jsonserializeroptions, cancellationToken).ConfigureAwait(false))
            ?? throw new Exception();
    }
}