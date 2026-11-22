// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceScalarBlockLayoutFeatures"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceScalarBlockLayoutFeaturesTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceScalarBlockLayoutFeatures"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceScalarBlockLayoutFeatures>(),
            Is.EqualTo(sizeof(PhysicalDeviceScalarBlockLayoutFeatures))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceScalarBlockLayoutFeatures"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceScalarBlockLayoutFeatures).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceScalarBlockLayoutFeatures"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PhysicalDeviceScalarBlockLayoutFeatures), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PhysicalDeviceScalarBlockLayoutFeatures), Is.EqualTo(12));
        }
    }
}
