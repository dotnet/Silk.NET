// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Text;
using Microsoft.Extensions.Logging;
using IOPath = System.IO.Path;

namespace Silk.NET.SilkTouch.Caching;

internal class FileSystemArchiveCacheDirectory(
    string cacheKey,
    string committedPath,
    CacheIntent intent,
    CacheFlags flags,
    FileAccess access,
    FileSystemCacheProvider parent
) : ICacheDirectory
{
    private ZipArchive? _committed;
    private bool _hasCommitted;
    private string? _newPath;
    private ZipArchive? _new;
    private HashSet<string>? _newEntries;
    private SemaphoreSlim _sema = new(1, 1);

    private async ValueTask<ZipArchive?> GetOrCreateCommittedAsync()
    {
        if (
            !File.Exists(committedPath)
            || (Flags & CacheFlags.RequireNew) == CacheFlags.RequireNew && !_hasCommitted
        )
        {
            parent.Logger.LogDebug(
                "Cache miss with key \"{0}\"! Expected ZIP archive at {1}",
                CacheKey,
                committedPath
            );
            return null;
        }

        parent.Logger.LogDebug(
            "Cache hit with key \"{0}\"! ZIP archive: {1}",
            CacheKey,
            committedPath
        );
        return _committed = await ZipArchive.CreateAsync(
            File.OpenRead(committedPath),
            ZipArchiveMode.Read,
            false,
            Encoding.UTF8
        );
    }

    // [MemberNotNull(nameof(_new))] <-- TODO WHY IS THE COMPILER NOT HAPPY?
    [MemberNotNull(nameof(_newEntries))]
    private async ValueTask<ZipArchive> GetOrCreateNewAsync()
    {
        if (_new is not null)
        {
            Debug.Assert(_newEntries is not null);
            return _new;
        }

        if ((Access & FileAccess.Write) == 0)
        {
            CacheUtils.ThrowAccessException();
#pragma warning disable CS8774 // Member must have a non-null value when exiting.
            return null!;
#pragma warning restore CS8774 // Member must have a non-null value when exiting.
        }

        _newPath = IOPath.GetTempFileName();
        parent.Logger.LogDebug(
            "Opening cache for write with key \"{0}\"! Temporary ZIP archive path: {1}",
            CacheKey,
            _newPath
        );
        _newEntries = [];
        return _new = await ZipArchive.CreateAsync(
            File.OpenWrite(_newPath),
            ZipArchiveMode.Create,
            false,
            Encoding.UTF8
        );
    }

    public string CacheKey { get; } = cacheKey;
    public CacheIntent Intent { get; } = intent;
    public CacheFlags Flags { get; } = flags;
    public FileAccess Access { get; } = access;
    public string? Path => null;

    public async IAsyncEnumerable<string> GetCommittedFilesAsync()
    {
        if ((Access & FileAccess.Read) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        foreach (
            var entry in (await GetOrCreateCommittedAsync())?.Entries
                ?? Enumerable.Empty<ZipArchiveEntry>()
        )
        {
            yield return entry.FullName.ToCacheEntryPath();
        }
    }

    public async ValueTask<Stream> GetCommittedFileAsync(string filePath)
    {
        if ((Access & FileAccess.Read) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        parent.Logger.LogTrace("Cache hit (\"{0}\", ZIP): {1}", CacheKey, filePath);
        var entry =
            _committed?.GetEntry(filePath.ToCacheEntryPath()) ?? throw new FileNotFoundException();
        return await entry.OpenAsync();
    }

    public async ValueTask AddFileAsync(string filePath, Stream stream)
    {
        filePath = filePath.ToCacheEntryPath();
        if ((Access & FileAccess.Write) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        await _sema.WaitAsync();
        try
        {
            parent.Logger.LogTrace("Cache write (\"{0}\", ZIP): {1}", CacheKey, filePath);
            await using var dst = await (await GetOrCreateNewAsync())
                .CreateEntry(filePath, CompressionLevel.SmallestSize)
                .OpenAsync();
            await stream.CopyToAsync(dst);
            _newEntries.Add(filePath);
        }
        finally
        {
            _sema.Release();
        }
    }

    public async ValueTask CommitAsync()
    {
        if ((Access & FileAccess.Write) == 0)
        {
            CacheUtils.ThrowAccessException();
        }

        await _sema.WaitAsync();
        try
        {
            parent.Logger.LogDebug(
                "Cache write with key \"{0}\"! ZIP archive: {1}",
                CacheKey,
                committedPath
            );
            var @new = await GetOrCreateNewAsync();
            if (_committed is not null)
            {
                // Copy old entries that haven't been overwritten.
                // If the user doesn't want this, they can use RequireNew.
                foreach (var entry in _committed.Entries)
                {
                    if (!_newEntries.Contains(entry.FullName.ToCacheEntryPath()))
                    {
                        parent.Logger.LogTrace(
                            "Cache unchanged (\"{0}\", ZIP): {1}",
                            CacheKey,
                            entry.FullName
                        );
                        await using var src = await (
                            _committed?.GetEntry(entry.FullName)
                            ?? throw new InvalidOperationException(
                                "Failed to open an entry that exists."
                            )
                        ).OpenAsync();
                        await using var dst = await @new.CreateEntry(
                                entry.FullName,
                                CompressionLevel.SmallestSize
                            )
                            .OpenAsync();
                        await src.CopyToAsync(dst);
                    }
                }

                await _committed.DisposeAsync();
                _committed = null;
            }

            await @new.DisposeAsync();
            _new = null;
            _hasCommitted = true;
            Debug.Assert(_newPath is not null);
            File.Move(_newPath, committedPath, true);
        }
        finally
        {
            _sema.Release();
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_new is not null)
        {
            parent.Logger.LogWarning(
                "Cache update abandoned with key \"{0}\"! ZIP archive: {1}",
                CacheKey,
                committedPath
            );
        }

        await (_committed?.DisposeAsync() ?? ValueTask.CompletedTask);
        await (_new?.DisposeAsync() ?? ValueTask.CompletedTask);
        if (_newPath is not null)
        {
            File.Delete(_newPath);
        }

        await parent.FreeAsync(CacheKey);
    }
}
