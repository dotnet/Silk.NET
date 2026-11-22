// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "Frustumf"/> struct.</summary>
public static unsafe partial class XrFrustumfTests
{
    /// <summary>Validates that the <see cref = "Frustumf"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Frustumf>(), Is.EqualTo(sizeof(Frustumf)));
    }

    /// <summary>Validates that the <see cref = "Frustumf"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Frustumf).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Frustumf"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Frustumf), Is.EqualTo(52));
    }
}
