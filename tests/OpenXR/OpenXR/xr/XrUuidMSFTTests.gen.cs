// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "UuidMSFT"/> struct.</summary>
public static unsafe partial class XrUuidMSFTTests
{
    /// <summary>Validates that the <see cref = "UuidMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UuidMSFT>(), Is.EqualTo(sizeof(UuidMSFT)));
    }

    /// <summary>Validates that the <see cref = "UuidMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UuidMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UuidMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UuidMSFT), Is.EqualTo(16));
    }
}
