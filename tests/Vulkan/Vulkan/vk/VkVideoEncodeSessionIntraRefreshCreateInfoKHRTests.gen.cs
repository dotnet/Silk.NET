// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "VideoEncodeSessionIntraRefreshCreateInfoKHR"/> struct.</summary>
public static unsafe partial class VkVideoEncodeSessionIntraRefreshCreateInfoKHRTests
{
    /// <summary>Validates that the <see cref = "VideoEncodeSessionIntraRefreshCreateInfoKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<VideoEncodeSessionIntraRefreshCreateInfoKHR>(),
            Is.EqualTo(sizeof(VideoEncodeSessionIntraRefreshCreateInfoKHR))
        );
    }

    /// <summary>Validates that the <see cref = "VideoEncodeSessionIntraRefreshCreateInfoKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(VideoEncodeSessionIntraRefreshCreateInfoKHR).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "VideoEncodeSessionIntraRefreshCreateInfoKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VideoEncodeSessionIntraRefreshCreateInfoKHR), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(VideoEncodeSessionIntraRefreshCreateInfoKHR), Is.EqualTo(12));
        }
    }
}
