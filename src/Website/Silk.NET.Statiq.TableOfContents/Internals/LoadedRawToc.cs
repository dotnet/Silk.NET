// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents.Internals
{
    internal record struct LoadedRawToc
    (
        NormalizedPath OriginalToCFile,
        (NormalizedPath Rel, TableOfContentsElement RootModel, TableOfContentsElement Model) Value
    );
}
