// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Caching;

internal static class CacheUtils
{
    internal static void ThrowAccessException() =>
        throw new NotSupportedException(
            "The cache directory has not been opened with the correct FileAccess for this operation."
        );

    internal static void ThrowRequireHostDirectoryNeedsWrite() =>
        throw new NotSupportedException(
            "CacheFlags.RequireHostDirectory needs FileAccess.Write due to the cache accesses being uncontrolled by "
                + "the cache system."
        );
}
