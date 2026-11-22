// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceMaintenance7PropertiesKHR"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceMaintenance7PropertiesKHRTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceMaintenance7PropertiesKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceMaintenance7PropertiesKHR>(),
            Is.EqualTo(sizeof(PhysicalDeviceMaintenance7PropertiesKHR))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMaintenance7PropertiesKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceMaintenance7PropertiesKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMaintenance7PropertiesKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceMaintenance7PropertiesKHR), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceMaintenance7PropertiesKHR), Is.EqualTo(40));
        }
    }
}
