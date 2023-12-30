using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Caching;

/// <summary>
/// An implementation of <see cref="ICacheProvider"/> using the filesystem.
/// </summary>
public class FileSystemCacheProvider(ILogger<FileSystemCacheProvider> logger) : ICacheProvider
{
    private readonly ConcurrentDictionary<string, SemaphoreSlim?> _semaphores = new();
    private readonly ConcurrentDictionary<string, ZipArchive> _noHostZips = new();

    internal static string CommonDir { get; set; } = Environment.CurrentDirectory;

    /// <inheritdoc />
    public async Task<(string Path, bool IsNew)?> GetDirectory(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags
    ) =>
        await CoreGetDirectory(cacheKey, intent, intent == CacheIntent.ResolvedForeignInput, flags);

    static string GetCachePath(string cacheKey, CacheIntent intent)
    {
        cacheKey = cacheKey.ToLower();
        var ext = intent switch
        {
            CacheIntent.ResolvedForeignInput => "stdownload",
            CacheIntent.StageIntermediateOutput => "stout",
            _ => throw new ArgumentOutOfRangeException(nameof(intent), intent, null)
        };
        return Path.Combine(CommonDir, ".silktouch", $"{cacheKey}.{ext}");
    }

    async Task<(string Path, bool IsNew)?> CoreGetDirectory(
        string cacheKey,
        CacheIntent intent,
        bool isUnstaged,
        CacheFlags flags
    )
    {
        var path = GetCachePath(cacheKey, intent);
        var sema = _semaphores.GetOrAdd(path, _ => new SemaphoreSlim(1, 1));
        await (sema?.WaitAsync() ?? Task.CompletedTask);
        if (
            sema is not null
            && ((isUnstaged && !Directory.Exists(path)) || (!isUnstaged && !File.Exists(path)))
        )
        {
            if ((flags & CacheFlags.AllowNewLocked) == 0)
            {
                sema.Release();
                return null;
            }

            logger.LogDebug("Cache miss: {} for {}", cacheKey, intent);
            if (isUnstaged)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                Directory.CreateDirectory(path);
            }
            else
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }

                if (Path.GetDirectoryName(path) is { } dn && !Directory.Exists(dn))
                {
                    Directory.CreateDirectory(dn);
                }

                if (File.Exists(path) && (flags & CacheFlags.NoHostDirectory) == 0)
                {
                    File.Move(path, path + ".tmp");
                    {
                        await using var fs = File.OpenRead(path);
                        using var arch = new ZipArchive(fs);
                        await Parallel.ForEachAsync(
                            arch.Entries,
                            async (entry, ct) =>
                            {
                                var options = new FileStreamOptions
                                {
                                    Access = FileAccess.Write,
                                    Mode = FileMode.Create,
                                    Share = FileShare.None,
                                    BufferSize = 4096
                                };
                                var unixFileMode = (UnixFileMode)(
                                    (entry.ExternalAttributes >> 16) & 511
                                );
                                if (
                                    unixFileMode != UnixFileMode.None
                                    && !OperatingSystem.IsWindows()
                                )
                                {
                                    options.UnixCreateMode = unixFileMode;
                                }

                                var dstPath = Path.Combine(path, entry.FullName);
                                Directory.CreateDirectory(Path.GetDirectoryName(dstPath) ?? path);
                                await using var destination = new FileStream(dstPath, options);
                                await using var stream = entry.Open();
                                await stream.CopyToAsync(destination, ct);
                                await destination.FlushAsync(ct);
                            }
                        );
                    }
                    File.Delete(path + ".tmp");
                }
                else if ((flags & CacheFlags.NoHostDirectory) != 0)
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    var za = new ZipArchive(File.OpenWrite(path), ZipArchiveMode.Create, false);
                    _noHostZips.TryAdd(path, za);
                }
            }

            return (path, true);
        }

        if ((flags & CacheFlags.RequireNewLocked) == CacheFlags.RequireNewLocked)
        {
            return null;
        }

        if (sema is not null)
        {
            _semaphores[path] = null;
            logger.LogInformation("Cache hit: {} for {}", cacheKey, intent);
            sema.Release();
        }

        return (path, false);
    }

    /// <inheritdoc />
    public async Task CommitFile(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags,
        string filePath,
        Stream stream
    )
    {
        var path = GetCachePath(cacheKey, intent);
        if ((flags & CacheFlags.NoHostDirectory) != 0 && _noHostZips.TryGetValue(path, out var zip))
        {
            var entry = zip.CreateEntry(filePath, CompressionLevel.SmallestSize);
            await using var s = entry.Open();
            await stream.CopyToAsync(s);
        }
        else
        {
            await using var s = File.OpenWrite(Path.Combine(path, filePath));
            await stream.CopyToAsync(s);
        }
    }

    /// <inheritdoc />
    public Task CommitDirectory(string cacheKey, CacheIntent intent, CacheFlags flags)
    {
        var path = GetCachePath(cacheKey, intent);
        if ((flags & CacheFlags.NoHostDirectory) != 0 && _noHostZips.TryGetValue(path, out var zip))
        {
            zip.Dispose();
            _noHostZips.TryRemove(new KeyValuePair<string, ZipArchive>(path, zip));
        }
        else if (_semaphores.TryGetValue(path, out var sema))
        {
            sema?.Release();
        }

        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task<IEnumerable<string>> GetFiles(string cacheKey, CacheIntent intent, CacheFlags flags)
    {
        var path = GetCachePath(cacheKey, intent);
        if ((flags & CacheFlags.NoHostDirectory) != 0 && _noHostZips.TryGetValue(path, out var zip))
        {
            return Task.FromResult(zip.Entries.Select(x => x.FullName));
        }

        return Task.FromResult<IEnumerable<string>>(
            Directory.GetFiles(path, "*", SearchOption.AllDirectories)
        );
    }

    /// <inheritdoc />
    public Task<Stream> GetFile(
        string cacheKey,
        CacheIntent intent,
        CacheFlags flags,
        string filePath
    )
    {
        var path = GetCachePath(cacheKey, intent);
        if ((flags & CacheFlags.NoHostDirectory) != 0 && _noHostZips.TryGetValue(path, out var zip))
        {
            var file = zip.GetEntry(filePath);
            if (file is null)
            {
                throw new FileNotFoundException(null, nameof(filePath));
            }

            return Task.FromResult(file.Open());
        }

        return Task.FromResult<Stream>(File.OpenRead(Path.Combine(path, filePath)));
    }
}
