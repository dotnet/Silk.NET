// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SecondaryViewConfigurationSessionBeginInfoMSFT"/> struct.</summary>
public static unsafe partial class XrSecondaryViewConfigurationSessionBeginInfoMSFTTests
{
    /// <summary>Validates that the <see cref = "SecondaryViewConfigurationSessionBeginInfoMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SecondaryViewConfigurationSessionBeginInfoMSFT>(),
            Is.EqualTo(sizeof(SecondaryViewConfigurationSessionBeginInfoMSFT))
        );
    }

    /// <summary>Validates that the <see cref = "SecondaryViewConfigurationSessionBeginInfoMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(SecondaryViewConfigurationSessionBeginInfoMSFT).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "SecondaryViewConfigurationSessionBeginInfoMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecondaryViewConfigurationSessionBeginInfoMSFT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SecondaryViewConfigurationSessionBeginInfoMSFT), Is.EqualTo(16));
        }
    }
}
