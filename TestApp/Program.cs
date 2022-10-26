using TweakblogsExportReader;

var reader = new TweakblogsExportJsonReader(); ;

// Read export file into blog
var blog = await reader.ReadAsync(@"path\to\tweakblog-export.json").ConfigureAwait(false);

// Get post titles
var posts = blog.Posts.Select(p => p.Title).ToArray();
