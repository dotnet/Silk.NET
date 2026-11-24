// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "HandPoseTypeInfoMSFT"/> struct.</summary>
public static unsafe partial class XrHandPoseTypeInfoMSFTTests
{
    /// <summary>Validates that the <see cref = "HandPoseTypeInfoMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HandPoseTypeInfoMSFT>(),
            Is.EqualTo(sizeof(HandPoseTypeInfoMSFT))
        );
    }

    /// <summary>Validates that the <see cref = "HandPoseTypeInfoMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HandPoseTypeInfoMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HandPoseTypeInfoMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HandPoseTypeInfoMSFT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(HandPoseTypeInfoMSFT), Is.EqualTo(12));
        }
    }
}
