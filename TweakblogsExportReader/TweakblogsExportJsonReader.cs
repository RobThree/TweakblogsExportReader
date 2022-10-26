using System.Text.Json;
using TweakblogsExportReader.Converters;
using TweakblogsExportReader.Models;

namespace TweakblogsExportReader;
public class TweakblogsExportJsonReader : ITweakblogsExportJsonReader
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
        return await ReadAsync(f, cancellationToken);
    }

    public async ValueTask<Blog> ReadAsync(Stream stream, CancellationToken cancellationToken = default)
        => (await JsonSerializer.DeserializeAsync<Blog>(stream, _jsonserializeroptions, cancellationToken).ConfigureAwait(false))
        ?? throw new JsonException("Error reading blog export");
}