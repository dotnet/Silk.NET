namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// A cache directory opened by a <see cref="ICacheProvider"/>.
/// </summary>
/// <remarks>
/// Cache directories must always be disposed, even in exceptional circumstances and regardless of whether they're being
/// committed. Failing to do so may result in the cache being prematurely deleted, as SilkTouch contains protections to
/// ensure that caches from successful jobs aren't affected by writes from subsequent unsuccessful jobs.
/// </remarks>
public interface ICacheDirectory : IAsyncDisposable
{
    /// <summary>
    /// Gets the cache key the directory was opened with.
    /// </summary>
    public string CacheKey { get; }

    /// <summary>
    /// Gets the intent the directory was opened with.
    /// </summary>
    public CacheIntent Intent { get; }

    /// <summary>
    /// Gets the flags the directory was opened with.
    /// </summary>
    public CacheFlags Flags { get; }

    /// <summary>
    /// Gets a value indicating the access level of this cache.
    /// </summary>
    public FileAccess Access { get; }

    /// <summary>
    /// Gets the path of this cache directory on disk. <c>null</c> if <see cref="CacheFlags"/> does not have the
    /// <see cref="CacheFlags.RequireHostDirectory"/> bit set.
    /// </summary>
    public string? Path { get; }

    /// <summary>
    /// Gets the file paths of the committed files within the cache.
    /// </summary>
    /// <returns>The file paths asynchronously.</returns>
    /// <exception cref="NotSupportedException">
    /// If <see cref="Access"/> does not have the <see cref="FileAccess.Read"/> bit set.
    /// </exception>
    public IAsyncEnumerable<string> GetCommittedFilesAsync();

    /// <summary>
    /// Gets the contents of the given committed file within the cache.
    /// </summary>
    /// <remarks>
    /// This can't be used to observe files that have been written
    /// </remarks>
    /// <param name="filePath">The file path, as previously returned from
    /// <see cref="GetCommittedFilesAsync"/>.</param>
    /// <returns>An asynchronous task.</returns>
    /// <exception cref="NotSupportedException">
    /// If <see cref="Access"/> does not have the <see cref="FileAccess.Read"/> bit set.
    /// </exception>
    /// <exception cref="FileNotFoundException">
    /// If the file does not exist in the cache or is not yet committed.
    /// </exception>
    public ValueTask<Stream> GetCommittedFileAsync(string filePath);

    /// <summary>
    /// Adds a file to be committed to the cache upon <see cref="CommitAsync"/>.
    /// </summary>
    /// <param name="filePath">The file path within the cache (i.e. not a filesystem path, or if it is, a relative
    /// one).</param>
    /// <param name="stream">The stream containing the data to be written.</param>
    /// <returns>An asynchronous task.</returns>
    public ValueTask AddFileAsync(string filePath, Stream stream);

    /// <summary>
    /// Commits the files added using <see cref="AddFileAsync"/> to the cache. If <see cref="FileAccess"/> is
    /// <see cref="FileAccess.ReadWrite"/>, this makes the added files observable via
    /// <see cref="GetCommittedFileAsync"/>/<see cref="GetCommittedFilesAsync"/>.
    /// </summary>
    /// <returns></returns>
    public ValueTask CommitAsync();
}
