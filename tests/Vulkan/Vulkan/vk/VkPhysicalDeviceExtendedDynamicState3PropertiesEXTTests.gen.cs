// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceExtendedDynamicState3PropertiesEXT"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceExtendedDynamicState3PropertiesEXTTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceExtendedDynamicState3PropertiesEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceExtendedDynamicState3PropertiesEXT>(),
            Is.EqualTo(sizeof(PhysicalDeviceExtendedDynamicState3PropertiesEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceExtendedDynamicState3PropertiesEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceExtendedDynamicState3PropertiesEXT).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceExtendedDynamicState3PropertiesEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceExtendedDynamicState3PropertiesEXT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceExtendedDynamicState3PropertiesEXT), Is.EqualTo(12));
        }
    }
}
