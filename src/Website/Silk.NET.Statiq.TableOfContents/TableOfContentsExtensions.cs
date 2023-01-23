// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents
{
    public static class TableOfContentsExtensions
    {
        public static TableOfContentsModel? GetToc(this IDocument doc)
            => doc.Get<TableOfContentsModel>(nameof(TableOfContentsModel));
    }
}
