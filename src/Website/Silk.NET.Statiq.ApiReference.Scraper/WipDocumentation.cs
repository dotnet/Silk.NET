// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Text;

namespace Silk.NET.Statiq.ApiReference.Scraper;

public record WipDocumentation
(
    Category Category,
    string Directory,
    string Name,
    ConcurrentDictionary<string, WipDocumentation> Children
)
{
    private StreamWriter? _writer = null;
    public StreamWriter Markdown
    {
        get
        {
            if (!System.IO.Directory.Exists(Directory))
            {
                System.IO.Directory.CreateDirectory(Directory);
            }

            return _writer ??= new StreamWriter(Path.Combine(Directory, Name) + ".md"){AutoFlush = true};
        }
    }
}
