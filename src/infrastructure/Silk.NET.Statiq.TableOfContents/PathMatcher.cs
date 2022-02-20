// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents
{
    public delegate bool PathMatcher(NormalizedPath pathInToc, NormalizedPath candidatePath);
}
