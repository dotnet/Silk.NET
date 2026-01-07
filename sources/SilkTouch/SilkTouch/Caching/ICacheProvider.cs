namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// Represents a cache directory provider for intermediate outputs.
/// </summary>
public interface ICacheProvider
{
    /// <summary>
    /// Gets a directory in which previous outputs with the given cache key are stored.
    /// </summary>
    /// <param name="cacheKey">Cache key.</param>
    /// <param name="intent">The intent behind the cache.</param>
    /// <param name="flags">The flags determining how the cache is stored/accessed.</param>
    /// <param name="access">The level of access required.</param>
    /// <returns>
    /// The directory, or <c>null</c> if the directory did not exist in the cache already and
    /// <see cref="CacheFlags.AllowNew"/> was not set.
    /// </returns>
    ValueTask<ICacheDirectory?> GetDirectoryAsync(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags,
        FileAccess access
    );
}
