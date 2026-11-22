// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialPolygon2DDataEXT"/> struct.</summary>
public static unsafe partial class XrSpatialPolygon2DDataEXTTests
{
    /// <summary>Validates that the <see cref = "SpatialPolygon2DDataEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialPolygon2DDataEXT>(),
            Is.EqualTo(sizeof(SpatialPolygon2DDataEXT))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialPolygon2DDataEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialPolygon2DDataEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialPolygon2DDataEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpatialPolygon2DDataEXT), Is.EqualTo(48));
    }
}
