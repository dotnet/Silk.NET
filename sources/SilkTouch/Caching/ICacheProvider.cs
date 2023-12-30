using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// Represents a cache directory provider for intermediate outputs.
/// </summary>
public interface ICacheProvider
{
    /// <summary>
    /// Gets a directory in which previous outputs with the given cache key are stored, and where new outputs should be
    /// written to.
    /// </summary>
    /// <param name="cacheKey">Cache key.</param>
    /// <param name="intent">The intent behind the cache.</param>
    /// <param name="flags"></param>
    /// <returns>The directory and whether it is new.</returns>
    Task<(string Path, bool IsNew)?> GetDirectory(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags
    );

    /// <summary>
    /// Finalises the cache output.
    /// </summary>
    /// <param name="cacheKey">Cache key.</param>
    /// <param name="intent">The intent behind the cache.</param>
    /// <param name="flags">The cache flags.</param>
    /// <returns>An asynchronous task.</returns>
    Task CommitDirectory(string cacheKey, CacheIntent intent, CacheFlags flags);

    /// <summary>
    /// Adds a file to the cache. Use this if <see cref="CacheFlags.NoHostDirectory"/>
    /// </summary>
    /// <param name="cacheKey">Cache key.</param>
    /// <param name="intent">The intent behind the cache.</param>
    /// <param name="flags">The cache flags.</param>
    /// <param name="filePath">The file path within the cache.</param>
    /// <param name="stream">The stream.</param>
    /// <returns>An asynchronous task.</returns>
    Task CommitFile(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags,
        string filePath,
        Stream stream
    );

    /// <summary>
    /// Gets the file paths within the cache.
    /// </summary>
    /// <param name="cacheKey">Cache key.</param>
    /// <param name="intent">The intent behind the cache.</param>
    /// <param name="flags">The cache flags.</param>
    /// <returns>The file paths asynchronously.</returns>
    Task<IEnumerable<string>> GetFiles(string cacheKey, CacheIntent intent, CacheFlags flags);

    /// <summary>
    /// Gets the contents of the given file within the cache.
    /// </summary>
    /// <param name="cacheKey">Cache key.</param>
    /// <param name="intent">The intent behind the cache.</param>
    /// <param name="flags">The cache flags.</param>
    /// <param name="filePath">The file path, as previously returned from <see cref="GetFiles"/>.</param>
    /// <returns>An asynchronous task.</returns>
    Task<Stream> GetFile(string cacheKey, CacheIntent intent, CacheFlags flags, string filePath);
}
