// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Caching;

namespace Silk.NET.SilkTouch.UnitTests.Caching;

public class CacheTests
{
    static CacheTests() => Init();

    private static void Init([CallerFilePath] string filePath = "")
    {
        FileSystemCacheProvider.CommonDir = Path.Combine(
            Path.GetDirectoryName(filePath)!,
            "TestData.tmp"
        );

        if (Directory.Exists(FileSystemCacheProvider.CommonDir))
        {
            Directory.Delete(FileSystemCacheProvider.CommonDir, true);
        }
    }

    private static string GetExpectedPath(string cacheKey, CacheIntent intent) =>
        Path.Combine(
            FileSystemCacheProvider.CommonDir,
            ".silktouch",
            cacheKey.ToLower()
                + (intent == CacheIntent.ResolvedForeignInput ? ".stdownload" : ".stout")
        );

    [Test]
    public async Task ShouldNotCreateNewCacheWithoutAllowNewAsync()
    {
        var provider = new FileSystemCacheProvider(new NullLogger<FileSystemCacheProvider>());
        var i = 0;
        foreach (
            var intent in (IEnumerable<CacheIntent>)
                [CacheIntent.ResolvedForeignInput, CacheIntent.StageIntermediateOutput]
        )
        {
            foreach (
                var flag in (IEnumerable<CacheFlags>)
                    [CacheFlags.None, CacheFlags.RequireHostDirectory]
            )
            {
                foreach (
                    var access in (IEnumerable<FileAccess>)
                        [FileAccess.Read, FileAccess.Write, FileAccess.ReadWrite]
                )
                {
                    var cacheKey = $"{nameof(ShouldNotCreateNewCacheWithoutAllowNewAsync)}{i++}";
                    var dir = await provider.GetDirectoryAsync(cacheKey, intent, flag, access);
                    using (Assert.EnterMultipleScope())
                    {
                        Assert.That(dir, Is.Null);
                        var expectedPath = GetExpectedPath(cacheKey, intent);
                        Assert.That(Directory.Exists(expectedPath), Is.False);
                        Assert.That(
                            File.Exists(
                                Path.Combine(FileSystemCacheProvider.CommonDir, cacheKey.ToLower())
                            ),
                            Is.False
                        );
                    }
                }
            }
        }
    }

    // TODO this could probably be split up into lots of little tests, but it's fine for now.
    [Test]
    public async Task ShouldCreateCacheWhenAllowNew()
    {
        var provider = new FileSystemCacheProvider(new NullLogger<FileSystemCacheProvider>());
        var i = 0;
        var read = new byte[4];
        foreach (
            var intent in (IEnumerable<CacheIntent>)
                [CacheIntent.ResolvedForeignInput, CacheIntent.StageIntermediateOutput]
        )
        {
            foreach (
                var flag in (IEnumerable<CacheFlags>)
                    [CacheFlags.None, CacheFlags.RequireHostDirectory]
            )
            {
                foreach (
                    var access in (IEnumerable<FileAccess>)[FileAccess.Write, FileAccess.ReadWrite]
                )
                {
                    var cacheKey = $"{nameof(ShouldCreateCacheWhenAllowNew)}{i++}";
                    var expectedPath = GetExpectedPath(cacheKey, intent);
                    for (var j = 0; j < 3; j++)
                    {
                        // Check we can create the cache
                        // If this is the third loop, we are testing RequireNew
                        var dir = await provider.GetDirectoryAsync(
                            cacheKey,
                            intent,
                            (j == 2 ? CacheFlags.RequireNew : CacheFlags.AllowNew) | flag,
                            access
                        );
                        Assert.That(dir, Is.Not.Null);
                        Assert.That(
                            dir.Path is null,
                            Is.EqualTo((flag & CacheFlags.RequireHostDirectory) == 0)
                        );

                        // Check we can't access our files before we commit them
                        if ((access & FileAccess.ReadWrite) == FileAccess.ReadWrite)
                        {
                            Assert.That(
                                await dir.GetCommittedFilesAsync().ToArrayAsync(),
                                j == 1
                                    ? Is.EquivalentTo(["test.txt"])
                                    : Is.EquivalentTo(Array.Empty<string>())
                            );

                            if (j == 1) // if the cache has been reopened but it's not RequireNew
                            {
                                await using var es = await dir.GetCommittedFileAsync("test.txt");
                                await es.ReadExactlyAsync(read);
                                Assert.That(read, Is.EquivalentTo("tset"u8.ToArray()));
                            }
                        }

                        foreach (
                            var contents in (IEnumerable<byte[]>)
                                ["test"u8.ToArray(), "tset"u8.ToArray()]
                        )
                        {
                            // Add a file to ensure commit works properly.
                            // If this is the second loop, we are testing we can overwrite.
                            await dir.AddFileAsync("test.txt", new MemoryStream(contents));
                            await dir.CommitAsync();
                            using (Assert.EnterMultipleScope())
                            {
                                Assert.That(
                                    Directory.Exists(expectedPath),
                                    Is.EqualTo((flag & CacheFlags.RequireHostDirectory) != 0)
                                );
                                Assert.That(
                                    File.Exists(expectedPath),
                                    Is.EqualTo((flag & CacheFlags.RequireHostDirectory) == 0)
                                );
                            }

                            // Check that we can access our committed files immediately if ReadWrite
                            if ((access & FileAccess.ReadWrite) == FileAccess.ReadWrite)
                            {
                                Assert.That(
                                    await dir.GetCommittedFilesAsync().ToArrayAsync(),
                                    Is.EquivalentTo(["test.txt"])
                                );

                                await using var es = await dir.GetCommittedFileAsync("test.txt");
                                await es.ReadExactlyAsync(read);
                                Assert.That(read, Is.EquivalentTo(contents));
                            }

                            // Check the cache contents
                            if ((flag & CacheFlags.RequireHostDirectory) != 0)
                            {
                                Assert.That(
                                    await File.ReadAllBytesAsync(
                                        Path.Combine(expectedPath, "test.txt")
                                    ),
                                    Is.EquivalentTo(contents)
                                );
                            }
                            else
                            {
                                await using var za = await ZipArchive.CreateAsync(
                                    File.OpenRead(expectedPath),
                                    ZipArchiveMode.Read,
                                    false,
                                    Encoding.UTF8
                                );
                                var entry = za.GetEntry("test.txt");
                                Assert.That(entry, Is.Not.Null);
                                await using var es = await entry.OpenAsync();
                                read.AsSpan().Clear();
                                await es.ReadExactlyAsync(read);
                                Assert.That(read, Is.EquivalentTo(contents));
                            }
                        }

                        // Check that we can't reopen until we've disposed
                        Assert.ThrowsAsync<InvalidOperationException>(async () =>
                        {
                            await provider.GetDirectoryAsync(
                                cacheKey,
                                intent,
                                CacheFlags.AllowNew | flag,
                                access
                            );
                        });

                        // Check that we can reopen (in the next loop)
                        await dir.DisposeAsync();
                    }
                }
            }
        }
    }
}
