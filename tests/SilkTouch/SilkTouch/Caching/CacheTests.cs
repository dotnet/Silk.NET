// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Caching;

namespace Silk.NET.SilkTouch.UnitTests.Caching;

public class CacheTests
{
    static CacheTests() => Init();

    private static void Init([CallerFilePath] string filePath = "") =>
        FileSystemCacheProvider.CommonDir = Path.Combine(
            Path.GetDirectoryName(filePath)!,
            "TestData.tmp"
        );

    [Test]
    public async Task ShouldNotCreateNewCacheWithoutAllowNewAsync()
    {
        var provider = new FileSystemCacheProvider(new NullLogger<FileSystemCacheProvider>());
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
                    var dir = await provider.GetDirectoryAsync(
                        "ShouldNotCreateNewCacheWithoutAllowNew",
                        intent,
                        flag,
                        access
                    );
                    Assert.That(dir, Is.Null);
                }
            }
        }
    }
}
