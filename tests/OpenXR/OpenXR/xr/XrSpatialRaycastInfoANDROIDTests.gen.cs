// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialRaycastInfoANDROID"/> struct.</summary>
public static unsafe partial class XrSpatialRaycastInfoANDROIDTests
{
    /// <summary>Validates that the <see cref = "SpatialRaycastInfoANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialRaycastInfoANDROID>(),
            Is.EqualTo(sizeof(SpatialRaycastInfoANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialRaycastInfoANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialRaycastInfoANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialRaycastInfoANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialRaycastInfoANDROID), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(SpatialRaycastInfoANDROID), Is.EqualTo(56));
        }
    }
}
