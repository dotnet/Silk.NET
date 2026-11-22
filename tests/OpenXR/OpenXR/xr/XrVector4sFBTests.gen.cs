// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "Vector4SFB"/> struct.</summary>
public static unsafe partial class XrVector4sFBTests
{
    /// <summary>Validates that the <see cref = "Vector4SFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Vector4SFB>(), Is.EqualTo(sizeof(Vector4SFB)));
    }

    /// <summary>Validates that the <see cref = "Vector4SFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Vector4SFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Vector4SFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Vector4SFB), Is.EqualTo(8));
    }
}
