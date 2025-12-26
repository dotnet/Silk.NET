// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging;
using IOPath = System.IO.Path;

namespace Silk.NET.SilkTouch.Caching;

internal class FileSystemDiskCacheDirectory(
    string cacheKey,
    string committedPath,
    CacheIntent intent,
    CacheFlags flags,
    FileAccess access,
    FileSystemCacheProvider parent
) : ICacheDirectory
{
    private string? _newPath;
    private bool _committed; // literally just for logging purposes

    public async ValueTask InitAsync()
    {
        if ((Flags & CacheFlags.RequireHostDirectory) != 0 && (Access & FileAccess.Write) == 0)
        {
            CacheUtils.ThrowRequireHostDirectoryNeedsWrite();
            return;
        }

        if (!Directory.Exists(committedPath))
        {
            parent.Logger.LogDebug(
                "Cache miss with key \"{0}\"! Expected directory at {1}",
                CacheKey,
                committedPath
            );
            return;
        }

        parent.Logger.LogDebug(
            "Cache hit with key \"{0}\"! Directory: {1}",
            CacheKey,
            committedPath
        );
        if ((Flags & CacheFlags.RequireHostDirectory) != 0)
        {
            // If they want to read the existing cache, do a defensive copy to ensure that we can fall back on the old
            // cache if things fail. This only happens if RequireHostDirectory is set because in the case that it isn't
            // set, we can just read from the old cache directory and write to the new path which is then copied into
            // the old cache directory.
            // TODO we should probably make this configurable i.e. "I am okay with this being clobbered on failure"
            // TODO should probably check the file attributes to not copy unnecessarily
            if (
                (Access & FileAccess.Read) != 0
                && (Flags & CacheFlags.RequireNew) != CacheFlags.RequireNew
            )
            {
                await Parallel.ForEachAsync(
                    Directory.GetFiles(committedPath, "*", SearchOption.AllDirectories),
                    async (x, ct) =>
                        await Task.Run(
                            () =>
                                File.Copy(
                                    x,
                                    IOPath.Combine(
                                        NewPath,
                                        IOPath.GetRelativePath(committedPath, x)
                                    )
                                ),
                            ct
                        )
                );
            }
        }
    }

    public string CacheKey { get; } = cacheKey;
    public CacheIntent Intent { get; } = intent;
    public CacheFlags Flags { get; } = flags;
    public FileAccess Access { get; } = access;

    private string NewPath
    {
        get
        {
            if (_newPath is not null)
            {
                return _newPath;
            }

            _newPath = IOPath.Combine(IOPath.GetTempPath(), IOPath.GetRandomFileName());
            parent.Logger.LogDebug(
                "Opening cache for write with key \"{0}\"! Temporary directory: {1}",
                CacheKey,
                _newPath
            );
            Directory.CreateDirectory(_newPath);
            return _newPath;
        }
    }
    public string? Path => (Flags & CacheFlags.RequireHostDirectory) != 0 ? _newPath : null;

    public IAsyncEnumerable<string> GetCommittedFilesAsync()
    {
        if ((Access & FileAccess.Read) == 0)
        {
            CacheUtils.ThrowAccessException();
        }
        return Directory
            .GetFiles(committedPath, "*", SearchOption.AllDirectories)
            .Select(x => IOPath.GetRelativePath(committedPath, x))
            .ToAsyncEnumerable();
    }

    public ValueTask<Stream> GetCommittedFileAsync(string filePath)
    {
        if ((Access & FileAccess.Read) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        parent.Logger.LogTrace("Cache hit (\"{0}\", directory): {1}", CacheKey, filePath);
        return ValueTask.FromResult<Stream>(File.OpenRead(IOPath.Combine(committedPath, filePath)));
    }

    public async ValueTask AddFileAsync(string filePath, Stream stream)
    {
        if ((Access & FileAccess.Write) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        parent.Logger.LogTrace("Cache write (\"{0}\", directory): {1}", CacheKey, filePath);
        await using var dst = File.OpenWrite(IOPath.Combine(NewPath, filePath));
        await stream.CopyToAsync(dst);
    }

    public async ValueTask CommitAsync()
    {
        if ((Access & FileAccess.Write) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        parent.Logger.LogDebug(
            "Cache write with key \"{0}\"! Directory: {1}",
            CacheKey,
            committedPath
        );

        if ((Flags & CacheFlags.RequireNew) == CacheFlags.RequireNew)
        {
            parent.Logger.LogTrace("Erasing {0} as RequireNew is set", committedPath);
            Directory.Delete(committedPath, true);
            Directory.CreateDirectory(committedPath);
        }

        if (_newPath is null)
        {
            parent.Logger.LogTrace(
                "There are no files for {0} as a result of this commit",
                committedPath
            );
            return;
        }

        parent.Logger.LogTrace(
            "Copying temporary directory {0} to {1} for cache key {2}",
            _newPath,
            committedPath,
            CacheKey
        );
        await Parallel.ForEachAsync(
            Directory.GetFiles(_newPath, "*", SearchOption.AllDirectories),
            async (x, ct) =>
                await Task.Run(
                    () =>
                    {
                        if ((Flags & CacheFlags.RequireHostDirectory) != 0)
                        {
                            File.Copy(
                                x,
                                IOPath.Combine(committedPath, IOPath.GetRelativePath(_newPath, x))
                            );
                        }
                        else
                        {
                            File.Move(
                                x,
                                IOPath.Combine(committedPath, IOPath.GetRelativePath(_newPath, x))
                            );
                        }
                    },
                    ct
                )
        );
        if ((Flags & CacheFlags.RequireHostDirectory) == 0)
        {
            Directory.Delete(_newPath, true);
            _newPath = null;
        }

        _committed = true;
    }

    public async ValueTask DisposeAsync()
    {
        if (!_committed)
        {
            parent.Logger.LogWarning(
                "Cache update abandoned with key \"{0}\"! Directory: {1}",
                CacheKey,
                committedPath
            );
        }

        if (_newPath is not null)
        {
            Directory.Delete(_newPath, true);
        }

        await parent.FreeAsync(CacheKey);
    }
}
