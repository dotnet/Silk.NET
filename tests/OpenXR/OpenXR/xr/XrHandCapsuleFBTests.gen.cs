// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "HandCapsuleFB"/> struct.</summary>
public static unsafe partial class XrHandCapsuleFBTests
{
    /// <summary>Validates that the <see cref = "HandCapsuleFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HandCapsuleFB>(), Is.EqualTo(sizeof(HandCapsuleFB)));
    }

    /// <summary>Validates that the <see cref = "HandCapsuleFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HandCapsuleFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HandCapsuleFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HandCapsuleFB), Is.EqualTo(32));
    }
}
