// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.Statiq.TableOfContents.Internals
{
    internal static class Utilities
    {
        internal static IEnumerable<T> Yield<T>(T thing)
        {
            yield return thing;
        }
    }
}
