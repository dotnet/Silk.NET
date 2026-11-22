// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialAnchorNameHTC"/> struct.</summary>
public static unsafe partial class XrSpatialAnchorNameHTCTests
{
    /// <summary>Validates that the <see cref = "SpatialAnchorNameHTC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialAnchorNameHTC>(),
            Is.EqualTo(sizeof(SpatialAnchorNameHTC))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialAnchorNameHTC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialAnchorNameHTC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialAnchorNameHTC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpatialAnchorNameHTC), Is.EqualTo(256));
    }
}
