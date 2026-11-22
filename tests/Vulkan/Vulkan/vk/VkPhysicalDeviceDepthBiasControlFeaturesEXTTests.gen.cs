// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceDepthBiasControlFeaturesEXT"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceDepthBiasControlFeaturesEXTTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceDepthBiasControlFeaturesEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceDepthBiasControlFeaturesEXT>(),
            Is.EqualTo(sizeof(PhysicalDeviceDepthBiasControlFeaturesEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceDepthBiasControlFeaturesEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceDepthBiasControlFeaturesEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceDepthBiasControlFeaturesEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceDepthBiasControlFeaturesEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceDepthBiasControlFeaturesEXT), Is.EqualTo(24));
        }
    }
}
