// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "NewSceneComputeInfoMSFT"/> struct.</summary>
public static unsafe partial class XrNewSceneComputeInfoMSFTTests
{
    /// <summary>Validates that the <see cref = "NewSceneComputeInfoMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<NewSceneComputeInfoMSFT>(),
            Is.EqualTo(sizeof(NewSceneComputeInfoMSFT))
        );
    }

    /// <summary>Validates that the <see cref = "NewSceneComputeInfoMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NewSceneComputeInfoMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NewSceneComputeInfoMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NewSceneComputeInfoMSFT), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(NewSceneComputeInfoMSFT), Is.EqualTo(64));
        }
    }
}
