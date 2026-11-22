// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "VideoEncodeH265FrameSizeKHR"/> struct.</summary>
public static unsafe partial class VkVideoEncodeH265FrameSizeKHRTests
{
    /// <summary>Validates that the <see cref = "VideoEncodeH265FrameSizeKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<VideoEncodeH265FrameSizeKHR>(),
            Is.EqualTo(sizeof(VideoEncodeH265FrameSizeKHR))
        );
    }

    /// <summary>Validates that the <see cref = "VideoEncodeH265FrameSizeKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VideoEncodeH265FrameSizeKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VideoEncodeH265FrameSizeKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VideoEncodeH265FrameSizeKHR), Is.EqualTo(12));
    }
}
