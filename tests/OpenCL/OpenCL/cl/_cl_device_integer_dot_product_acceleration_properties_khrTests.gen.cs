// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "DeviceIntegerDotProductAccelerationPropertiesKHR"/> struct.</summary>
public static unsafe partial class _cl_device_integer_dot_product_acceleration_properties_khrTests
{
    /// <summary>Validates that the <see cref = "DeviceIntegerDotProductAccelerationPropertiesKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DeviceIntegerDotProductAccelerationPropertiesKHR>(),
            Is.EqualTo(sizeof(DeviceIntegerDotProductAccelerationPropertiesKHR))
        );
    }

    /// <summary>Validates that the <see cref = "DeviceIntegerDotProductAccelerationPropertiesKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(DeviceIntegerDotProductAccelerationPropertiesKHR).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "DeviceIntegerDotProductAccelerationPropertiesKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DeviceIntegerDotProductAccelerationPropertiesKHR), Is.EqualTo(24));
    }
}
