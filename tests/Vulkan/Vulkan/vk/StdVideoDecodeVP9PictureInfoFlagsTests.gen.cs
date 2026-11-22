// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "StdVideoDecodeVp9PictureInfoFlags"/> struct.</summary>
public static unsafe partial class StdVideoDecodeVP9PictureInfoFlagsTests
{
    /// <summary>Validates that the <see cref = "StdVideoDecodeVp9PictureInfoFlags"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<StdVideoDecodeVp9PictureInfoFlags>(),
            Is.EqualTo(sizeof(StdVideoDecodeVp9PictureInfoFlags))
        );
    }

    /// <summary>Validates that the <see cref = "StdVideoDecodeVp9PictureInfoFlags"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoDecodeVp9PictureInfoFlags).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "StdVideoDecodeVp9PictureInfoFlags"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoDecodeVp9PictureInfoFlags), Is.EqualTo(4));
    }
}
