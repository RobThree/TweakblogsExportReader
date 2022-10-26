# TweakblogsExportReader

A quick'n'dirty .Net library for reading [Tweakblogs export files](https://tweakers.net/plan/3726/we-nemen-afscheid-van-tweakblogs.html) to aid in conversion to other platforms. Available as [NuGet package](https://www.nuget.org/packages/TweakblogsExportReader).

## Quickstart

```c#
using TweakblogsExportReader;

var reader = new TweakblogsExportJsonReader(); ;

// Read export file into blog
var blog = await reader.ReadAsync(@"path\to\tweakblog-export.json").ConfigureAwait(false);

// Get post titles
var posts = blog.Posts.Select(p => p.Title).ToArray();
```