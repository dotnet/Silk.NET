// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DeviceFaultDebugInfoKHR"/> struct.</summary>
public static unsafe partial class VkDeviceFaultDebugInfoKHRTests
{
    /// <summary>Validates that the <see cref = "DeviceFaultDebugInfoKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DeviceFaultDebugInfoKHR>(),
            Is.EqualTo(sizeof(DeviceFaultDebugInfoKHR))
        );
    }

    /// <summary>Validates that the <see cref = "DeviceFaultDebugInfoKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceFaultDebugInfoKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DeviceFaultDebugInfoKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DeviceFaultDebugInfoKHR), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DeviceFaultDebugInfoKHR), Is.EqualTo(16));
        }
    }
}
