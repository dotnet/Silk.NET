// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DeviceCreateInfo"/> struct.</summary>
public static unsafe partial class VkDeviceCreateInfoTests
{
    /// <summary>Validates that the <see cref = "DeviceCreateInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DeviceCreateInfo>(), Is.EqualTo(sizeof(DeviceCreateInfo)));
    }

    /// <summary>Validates that the <see cref = "DeviceCreateInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DeviceCreateInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DeviceCreateInfo), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(DeviceCreateInfo), Is.EqualTo(40));
        }
    }
}
