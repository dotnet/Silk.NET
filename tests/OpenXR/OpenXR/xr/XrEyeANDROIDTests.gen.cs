// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EyeANDROID"/> struct.</summary>
public static unsafe partial class XrEyeANDROIDTests
{
    /// <summary>Validates that the <see cref = "EyeANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EyeANDROID>(), Is.EqualTo(sizeof(EyeANDROID)));
    }

    /// <summary>Validates that the <see cref = "EyeANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EyeANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EyeANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EyeANDROID), Is.EqualTo(32));
    }
}
