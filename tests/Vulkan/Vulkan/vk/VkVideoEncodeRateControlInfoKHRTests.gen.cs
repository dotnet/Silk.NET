// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "VideoEncodeRateControlInfoKHR"/> struct.</summary>
public static unsafe partial class VkVideoEncodeRateControlInfoKHRTests
{
    /// <summary>Validates that the <see cref = "VideoEncodeRateControlInfoKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<VideoEncodeRateControlInfoKHR>(),
            Is.EqualTo(sizeof(VideoEncodeRateControlInfoKHR))
        );
    }

    /// <summary>Validates that the <see cref = "VideoEncodeRateControlInfoKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VideoEncodeRateControlInfoKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VideoEncodeRateControlInfoKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VideoEncodeRateControlInfoKHR), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(VideoEncodeRateControlInfoKHR), Is.EqualTo(32));
        }
    }
}
