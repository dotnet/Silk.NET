// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceImageViewImageFormatInfoEXT"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceImageViewImageFormatInfoEXTTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceImageViewImageFormatInfoEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceImageViewImageFormatInfoEXT>(),
            Is.EqualTo(sizeof(PhysicalDeviceImageViewImageFormatInfoEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceImageViewImageFormatInfoEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceImageViewImageFormatInfoEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceImageViewImageFormatInfoEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceImageViewImageFormatInfoEXT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceImageViewImageFormatInfoEXT), Is.EqualTo(12));
        }
    }
}
