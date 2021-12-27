// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Text;

namespace Silk.NET.Statiq.ApiReference.Scraper;

public record WipDocumentation
(
    Category Category,
    StringBuilder Markdown,
    ConcurrentDictionary<string, WipDocumentation> Children
);
