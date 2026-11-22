// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialAnchorSpaceCreateInfoMSFT"/> struct.</summary>
public static unsafe partial class XrSpatialAnchorSpaceCreateInfoMSFTTests
{
    /// <summary>Validates that the <see cref = "SpatialAnchorSpaceCreateInfoMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialAnchorSpaceCreateInfoMSFT>(),
            Is.EqualTo(sizeof(SpatialAnchorSpaceCreateInfoMSFT))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialAnchorSpaceCreateInfoMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialAnchorSpaceCreateInfoMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialAnchorSpaceCreateInfoMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialAnchorSpaceCreateInfoMSFT), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(SpatialAnchorSpaceCreateInfoMSFT), Is.EqualTo(40));
        }
    }
}
