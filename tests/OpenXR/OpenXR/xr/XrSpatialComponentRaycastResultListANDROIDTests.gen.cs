// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialComponentRaycastResultListANDROID"/> struct.</summary>
public static unsafe partial class XrSpatialComponentRaycastResultListANDROIDTests
{
    /// <summary>Validates that the <see cref = "SpatialComponentRaycastResultListANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialComponentRaycastResultListANDROID>(),
            Is.EqualTo(sizeof(SpatialComponentRaycastResultListANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialComponentRaycastResultListANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialComponentRaycastResultListANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialComponentRaycastResultListANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialComponentRaycastResultListANDROID), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SpatialComponentRaycastResultListANDROID), Is.EqualTo(16));
        }
    }
}
