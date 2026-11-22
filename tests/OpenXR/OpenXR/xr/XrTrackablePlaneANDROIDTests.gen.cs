// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "TrackablePlaneANDROID"/> struct.</summary>
public static unsafe partial class XrTrackablePlaneANDROIDTests
{
    /// <summary>Validates that the <see cref = "TrackablePlaneANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<TrackablePlaneANDROID>(),
            Is.EqualTo(sizeof(TrackablePlaneANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "TrackablePlaneANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TrackablePlaneANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TrackablePlaneANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TrackablePlaneANDROID), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(TrackablePlaneANDROID), Is.EqualTo(88));
        }
    }
}
