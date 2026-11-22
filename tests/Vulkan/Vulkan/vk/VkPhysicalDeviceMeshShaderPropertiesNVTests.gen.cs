// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceMeshShaderPropertiesNV"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceMeshShaderPropertiesNVTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceMeshShaderPropertiesNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceMeshShaderPropertiesNV>(),
            Is.EqualTo(sizeof(PhysicalDeviceMeshShaderPropertiesNV))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMeshShaderPropertiesNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceMeshShaderPropertiesNV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceMeshShaderPropertiesNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceMeshShaderPropertiesNV), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceMeshShaderPropertiesNV), Is.EqualTo(76));
        }
    }
}
