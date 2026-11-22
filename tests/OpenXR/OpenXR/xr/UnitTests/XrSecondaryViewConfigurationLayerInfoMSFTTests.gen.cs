// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SecondaryViewConfigurationLayerInfoMSFT"/> struct.</summary>
public static unsafe partial class XrSecondaryViewConfigurationLayerInfoMSFTTests
{
    /// <summary>Validates that the <see cref = "SecondaryViewConfigurationLayerInfoMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SecondaryViewConfigurationLayerInfoMSFT>(),
            Is.EqualTo(sizeof(SecondaryViewConfigurationLayerInfoMSFT))
        );
    }

    /// <summary>Validates that the <see cref = "SecondaryViewConfigurationLayerInfoMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecondaryViewConfigurationLayerInfoMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecondaryViewConfigurationLayerInfoMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecondaryViewConfigurationLayerInfoMSFT), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SecondaryViewConfigurationLayerInfoMSFT), Is.EqualTo(24));
        }
    }
}
