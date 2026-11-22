// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceMemoryProperties2"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceMemoryProperties2Tests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceMemoryProperties2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceMemoryProperties2>(),
            Is.EqualTo(sizeof(PhysicalDeviceMemoryProperties2))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMemoryProperties2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceMemoryProperties2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMemoryProperties2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceMemoryProperties2), Is.EqualTo(536));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceMemoryProperties2), Is.EqualTo(528));
        }
    }
}
