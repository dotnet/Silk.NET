// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "VideoEncodeH264CapabilitiesKHR"/> struct.</summary>
public static unsafe partial class VkVideoEncodeH264CapabilitiesKHRTests
{
    /// <summary>Validates that the <see cref = "VideoEncodeH264CapabilitiesKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<VideoEncodeH264CapabilitiesKHR>(),
            Is.EqualTo(sizeof(VideoEncodeH264CapabilitiesKHR))
        );
    }

    /// <summary>Validates that the <see cref = "VideoEncodeH264CapabilitiesKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VideoEncodeH264CapabilitiesKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VideoEncodeH264CapabilitiesKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VideoEncodeH264CapabilitiesKHR), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(VideoEncodeH264CapabilitiesKHR), Is.EqualTo(60));
        }
    }
}
