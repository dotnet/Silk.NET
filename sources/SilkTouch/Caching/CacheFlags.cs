using System;

namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// Flags for opening cached directories/files.
/// </summary>
[Flags]
public enum CacheFlags
{
    /// <summary>
    /// If the cache doesn't exist, allow it to be created and lock other callers from accessing the directory until it
    /// is committed.
    /// </summary>
    AllowNewLocked = 1,

    /// <summary>
    /// Same as <see cref="AllowNewLocked"/>, but does not return a directory unless it is brand new.
    /// </summary>
    RequireNewLocked = 1 | (1 << 1),

    /// <summary>
    /// Don't write cache files to disk.
    /// </summary>
    NoHostDirectory = 1 << 2
}
