// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents.Internals
{
    internal record struct BakedToc
    (
        ConcurrentDictionary<NormalizedPath, (TableOfContentsElement Root, TableOfContentsElement Value)> TocMap
    );
}
