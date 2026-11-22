// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpaceLocations"/> struct.</summary>
public static unsafe partial class XrSpaceLocationsTests
{
    /// <summary>Validates that the <see cref = "SpaceLocations"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpaceLocations>(), Is.EqualTo(sizeof(SpaceLocations)));
    }

    /// <summary>Validates that the <see cref = "SpaceLocations"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpaceLocations).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpaceLocations"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpaceLocations), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SpaceLocations), Is.EqualTo(16));
        }
    }
}
