// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "FrameEndInfo"/> struct.</summary>
public static unsafe partial class XrFrameEndInfoTests
{
    /// <summary>Validates that the <see cref = "FrameEndInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FrameEndInfo>(), Is.EqualTo(sizeof(FrameEndInfo)));
    }

    /// <summary>Validates that the <see cref = "FrameEndInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FrameEndInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FrameEndInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FrameEndInfo), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(FrameEndInfo), Is.EqualTo(32));
        }
    }
}
