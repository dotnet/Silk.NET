// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DisplayPlaneInfo2KHR"/> struct.</summary>
public static unsafe partial class VkDisplayPlaneInfo2KHRTests
{
    /// <summary>Validates that the <see cref = "DisplayPlaneInfo2KHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DisplayPlaneInfo2KHR>(),
            Is.EqualTo(sizeof(DisplayPlaneInfo2KHR))
        );
    }

    /// <summary>Validates that the <see cref = "DisplayPlaneInfo2KHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DisplayPlaneInfo2KHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DisplayPlaneInfo2KHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DisplayPlaneInfo2KHR), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DisplayPlaneInfo2KHR), Is.EqualTo(16));
        }
    }
}
