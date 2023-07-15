// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IThumbnailStreamCache"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IThumbnailStreamCacheTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IThumbnailStreamCache"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IThumbnailStreamCache).GUID, Is.EqualTo(IID_IThumbnailStreamCache));
    }

    /// <summary>Validates that the <see cref = "IThumbnailStreamCache"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IThumbnailStreamCache>(), Is.EqualTo(sizeof(IThumbnailStreamCache)));
    }

    /// <summary>Validates that the <see cref = "IThumbnailStreamCache"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IThumbnailStreamCache).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IThumbnailStreamCache"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IThumbnailStreamCache), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IThumbnailStreamCache), Is.EqualTo(4));
        }
    }
}