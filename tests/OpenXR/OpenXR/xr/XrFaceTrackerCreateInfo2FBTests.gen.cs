// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "FaceTrackerCreateInfo2FB"/> struct.</summary>
public static unsafe partial class XrFaceTrackerCreateInfo2FBTests
{
    /// <summary>Validates that the <see cref = "FaceTrackerCreateInfo2FB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FaceTrackerCreateInfo2FB>(),
            Is.EqualTo(sizeof(FaceTrackerCreateInfo2FB))
        );
    }

    /// <summary>Validates that the <see cref = "FaceTrackerCreateInfo2FB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FaceTrackerCreateInfo2FB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FaceTrackerCreateInfo2FB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FaceTrackerCreateInfo2FB), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(FaceTrackerCreateInfo2FB), Is.EqualTo(20));
        }
    }
}
