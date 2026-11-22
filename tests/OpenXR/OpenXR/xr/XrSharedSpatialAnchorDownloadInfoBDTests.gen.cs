// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SharedSpatialAnchorDownloadInfoBD"/> struct.</summary>
public static unsafe partial class XrSharedSpatialAnchorDownloadInfoBDTests
{
    /// <summary>Validates that the <see cref = "SharedSpatialAnchorDownloadInfoBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SharedSpatialAnchorDownloadInfoBD>(),
            Is.EqualTo(sizeof(SharedSpatialAnchorDownloadInfoBD))
        );
    }

    /// <summary>Validates that the <see cref = "SharedSpatialAnchorDownloadInfoBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SharedSpatialAnchorDownloadInfoBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SharedSpatialAnchorDownloadInfoBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SharedSpatialAnchorDownloadInfoBD), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SharedSpatialAnchorDownloadInfoBD), Is.EqualTo(24));
        }
    }
}
