// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEITests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI>(),
            Is.EqualTo(sizeof(PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(
                sizeof(PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI),
                Is.EqualTo(24)
            );
        }
        else
        {
            Assert.That(
                sizeof(PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI),
                Is.EqualTo(12)
            );
        }
    }
}
