// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceExtendedDynamicState2FeaturesEXT"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceExtendedDynamicState2FeaturesEXTTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceExtendedDynamicState2FeaturesEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceExtendedDynamicState2FeaturesEXT>(),
            Is.EqualTo(sizeof(PhysicalDeviceExtendedDynamicState2FeaturesEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceExtendedDynamicState2FeaturesEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceExtendedDynamicState2FeaturesEXT).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceExtendedDynamicState2FeaturesEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceExtendedDynamicState2FeaturesEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceExtendedDynamicState2FeaturesEXT), Is.EqualTo(20));
        }
    }
}
