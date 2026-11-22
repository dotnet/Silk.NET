// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceMemoryProperties"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceMemoryPropertiesTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceMemoryProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceMemoryProperties>(),
            Is.EqualTo(sizeof(PhysicalDeviceMemoryProperties))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMemoryProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceMemoryProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMemoryProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PhysicalDeviceMemoryProperties), Is.EqualTo(520));
    }
}
