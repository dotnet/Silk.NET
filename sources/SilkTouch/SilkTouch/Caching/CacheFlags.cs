// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// Flags for opening cached directories/files.
/// </summary>
[Flags]
public enum CacheFlags
{
    /// <summary>
    /// No flags set.
    /// </summary>
    None = 0,

    /// <summary>
    /// If the cache doesn't exist, allow it to be created.
    /// </summary>
    AllowNew = 1,

    /// <summary>
    /// Same as <see cref="AllowNew"/> but the new cache will replace the old cache once committed.
    /// </summary>
    RequireNew = AllowNew | (1 << 1),

    /// <summary>
    /// The cache provider needs the cache directory to reside on disk.
    /// </summary>
    RequireHostDirectory = 1 << 3,
}
