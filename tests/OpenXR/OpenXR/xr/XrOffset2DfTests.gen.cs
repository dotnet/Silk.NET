// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "Offset2Df"/> struct.</summary>
public static unsafe partial class XrOffset2DfTests
{
    /// <summary>Validates that the <see cref = "Offset2Df"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Offset2Df>(), Is.EqualTo(sizeof(Offset2Df)));
    }

    /// <summary>Validates that the <see cref = "Offset2Df"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Offset2Df).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Offset2Df"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Offset2Df), Is.EqualTo(8));
    }
}
