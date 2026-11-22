// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceMaintenance6Features"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceMaintenance6FeaturesTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceMaintenance6Features"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceMaintenance6Features>(),
            Is.EqualTo(sizeof(PhysicalDeviceMaintenance6Features))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMaintenance6Features"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceMaintenance6Features).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMaintenance6Features"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceMaintenance6Features), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceMaintenance6Features), Is.EqualTo(12));
        }
    }
}
