// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DeviceGroupSubmitInfo"/> struct.</summary>
public static unsafe partial class VkDeviceGroupSubmitInfoTests
{
    /// <summary>Validates that the <see cref = "DeviceGroupSubmitInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DeviceGroupSubmitInfo>(),
            Is.EqualTo(sizeof(DeviceGroupSubmitInfo))
        );
    }

    /// <summary>Validates that the <see cref = "DeviceGroupSubmitInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceGroupSubmitInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DeviceGroupSubmitInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DeviceGroupSubmitInfo), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(DeviceGroupSubmitInfo), Is.EqualTo(32));
        }
    }
}
