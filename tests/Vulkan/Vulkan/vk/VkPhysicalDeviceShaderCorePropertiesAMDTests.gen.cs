// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceShaderCorePropertiesAMD"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceShaderCorePropertiesAMDTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderCorePropertiesAMD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceShaderCorePropertiesAMD>(),
            Is.EqualTo(sizeof(PhysicalDeviceShaderCorePropertiesAMD))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderCorePropertiesAMD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceShaderCorePropertiesAMD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceShaderCorePropertiesAMD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceShaderCorePropertiesAMD), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceShaderCorePropertiesAMD), Is.EqualTo(64));
        }
    }
}
