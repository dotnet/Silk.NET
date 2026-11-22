// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "VideoEncodeFeedback2CapabilitiesKHR"/> struct.</summary>
public static unsafe partial class VkVideoEncodeFeedback2CapabilitiesKHRTests
{
    /// <summary>Validates that the <see cref = "VideoEncodeFeedback2CapabilitiesKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<VideoEncodeFeedback2CapabilitiesKHR>(),
            Is.EqualTo(sizeof(VideoEncodeFeedback2CapabilitiesKHR))
        );
    }

    /// <summary>Validates that the <see cref = "VideoEncodeFeedback2CapabilitiesKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VideoEncodeFeedback2CapabilitiesKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VideoEncodeFeedback2CapabilitiesKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VideoEncodeFeedback2CapabilitiesKHR), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(VideoEncodeFeedback2CapabilitiesKHR), Is.EqualTo(16));
        }
    }
}
