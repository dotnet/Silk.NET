// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialAnchorsCreateInfoFromPoseML"/> struct.</summary>
public static unsafe partial class XrSpatialAnchorsCreateInfoFromPoseMLTests
{
    /// <summary>Validates that the <see cref = "SpatialAnchorsCreateInfoFromPoseML"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialAnchorsCreateInfoFromPoseML>(),
            Is.EqualTo(sizeof(SpatialAnchorsCreateInfoFromPoseML))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialAnchorsCreateInfoFromPoseML"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialAnchorsCreateInfoFromPoseML).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialAnchorsCreateInfoFromPoseML"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialAnchorsCreateInfoFromPoseML), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(SpatialAnchorsCreateInfoFromPoseML), Is.EqualTo(48));
        }
    }
}
