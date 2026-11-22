// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceShaderSubgroupExtendedTypesFeatures"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderSubgroupExtendedTypesFeatures"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceShaderSubgroupExtendedTypesFeatures>(),
            Is.EqualTo(sizeof(PhysicalDeviceShaderSubgroupExtendedTypesFeatures))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderSubgroupExtendedTypesFeatures"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceShaderSubgroupExtendedTypesFeatures).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderSubgroupExtendedTypesFeatures"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceShaderSubgroupExtendedTypesFeatures), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceShaderSubgroupExtendedTypesFeatures), Is.EqualTo(12));
        }
    }
}
