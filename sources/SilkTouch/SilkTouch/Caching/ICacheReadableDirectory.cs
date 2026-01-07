// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// A directory opened from a <see cref="ICacheProvider"/> for reading.
/// </summary>
public interface ICacheReadableDirectory : ICacheDirectory
{
    /// <summary>
    /// Returns a <see cref="ICacheWritableDirectory"/> initially populated with the current contents of this directory
    /// that can be used to write new data to the existing cache.
    /// </summary>
    /// <returns>The writable directory.</returns>
    public ValueTask<ICacheWritableDirectory> UpdateAsync();
}
