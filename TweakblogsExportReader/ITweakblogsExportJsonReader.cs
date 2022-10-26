using TweakblogsExportReader.Models;

namespace TweakblogsExportReader;
public interface ITweakblogsExportJsonReader
{
    ValueTask<Blog> ReadAsync(Stream stream, CancellationToken cancellationToken = default);
    ValueTask<Blog> ReadAsync(string path, CancellationToken cancellationToken = default);
}