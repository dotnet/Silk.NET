using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// An implementation of <see cref="ICacheProvider"/> using the filesystem.
/// </summary>
public class FileSystemCacheProvider(ILogger<FileSystemCacheProvider> logger) : ICacheProvider
{
    private readonly SemaphoreSlim _accessSema = new(1, 1);
    private readonly HashSet<string> _openKeys = new();

    internal static string CommonDir { get; set; } = Environment.CurrentDirectory;
    internal ILogger<FileSystemCacheProvider> Logger { get; } = logger;

    static string GetCachePath(string cacheKey, CacheIntent intent)
    {
        cacheKey = cacheKey.ToLower();
        var ext = intent switch
        {
            CacheIntent.ResolvedForeignInput => "stdownload",
            CacheIntent.StageIntermediateOutput => "stout",
            _ => throw new ArgumentOutOfRangeException(nameof(intent), intent, null),
        };
        return Path.Combine(CommonDir, ".silktouch", $"{cacheKey}.{ext}");
    }

    /// <inheritdoc />
    public async ValueTask<ICacheDirectory?> GetDirectoryAsync(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags,
        FileAccess access
    )
    {
        await _accessSema.WaitAsync();
        try
        {
            if (!_openKeys.Add(cacheKey))
            {
                throw new InvalidOperationException("Cache key is already open");
            }

            try
            {
                var committedPath = GetCachePath(cacheKey, intent);
                if (
                    (flags & CacheFlags.AllowNew) == 0
                    && (Directory.Exists(committedPath) || File.Exists(committedPath))
                )
                {
                    return null;
                }

                if (
                    (flags & CacheFlags.RequireHostDirectory) == 0
                    && !Directory.Exists(committedPath)
                )
                {
                    return new FileSystemArchiveCacheDirectory(
                        cacheKey,
                        committedPath,
                        intent,
                        flags,
                        access,
                        this
                    );
                }

                var ret = new FileSystemDiskCacheDirectory(
                    cacheKey,
                    committedPath,
                    intent,
                    flags,
                    access,
                    this
                );
                await ret.InitAsync();
                return ret;
            }
            catch
            {
                _openKeys.Remove(cacheKey);
                throw;
            }
        }
        finally
        {
            _accessSema.Release();
        }
    }

    internal async ValueTask FreeAsync(string cacheKey)
    {
        await _accessSema.WaitAsync();
        _openKeys.Remove(cacheKey);
        _accessSema.Release();
    }
}
