// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceLinearColorAttachmentFeaturesNV"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceLinearColorAttachmentFeaturesNVTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceLinearColorAttachmentFeaturesNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceLinearColorAttachmentFeaturesNV>(),
            Is.EqualTo(sizeof(PhysicalDeviceLinearColorAttachmentFeaturesNV))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceLinearColorAttachmentFeaturesNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PhysicalDeviceLinearColorAttachmentFeaturesNV).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceLinearColorAttachmentFeaturesNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceLinearColorAttachmentFeaturesNV), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceLinearColorAttachmentFeaturesNV), Is.EqualTo(12));
        }
    }
}
