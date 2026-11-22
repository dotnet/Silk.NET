// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceCooperativeMatrixPropertiesNV"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceCooperativeMatrixPropertiesNVTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceCooperativeMatrixPropertiesNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceCooperativeMatrixPropertiesNV>(),
            Is.EqualTo(sizeof(PhysicalDeviceCooperativeMatrixPropertiesNV))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceCooperativeMatrixPropertiesNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceCooperativeMatrixPropertiesNV).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceCooperativeMatrixPropertiesNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceCooperativeMatrixPropertiesNV), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceCooperativeMatrixPropertiesNV), Is.EqualTo(12));
        }
    }
}
