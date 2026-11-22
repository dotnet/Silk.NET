// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "FrameBeginInfo"/> struct.</summary>
public static unsafe partial class XrFrameBeginInfoTests
{
    /// <summary>Validates that the <see cref = "FrameBeginInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FrameBeginInfo>(), Is.EqualTo(sizeof(FrameBeginInfo)));
    }

    /// <summary>Validates that the <see cref = "FrameBeginInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FrameBeginInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FrameBeginInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FrameBeginInfo), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(FrameBeginInfo), Is.EqualTo(8));
        }
    }
}
