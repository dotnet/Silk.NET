// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNVTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV>(),
            Is.EqualTo(sizeof(PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV), Is.EqualTo(12));
        }
    }
}
