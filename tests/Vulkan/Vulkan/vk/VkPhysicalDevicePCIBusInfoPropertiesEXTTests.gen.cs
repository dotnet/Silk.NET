// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDevicePciBusInfoPropertiesEXT"/> struct.</summary>
public static unsafe partial class VkPhysicalDevicePCIBusInfoPropertiesEXTTests
{
    /// <summary>Validates that the <see cref = "PhysicalDevicePciBusInfoPropertiesEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDevicePciBusInfoPropertiesEXT>(),
            Is.EqualTo(sizeof(PhysicalDevicePciBusInfoPropertiesEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDevicePciBusInfoPropertiesEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDevicePciBusInfoPropertiesEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDevicePciBusInfoPropertiesEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDevicePciBusInfoPropertiesEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PhysicalDevicePciBusInfoPropertiesEXT), Is.EqualTo(24));
        }
    }
}
