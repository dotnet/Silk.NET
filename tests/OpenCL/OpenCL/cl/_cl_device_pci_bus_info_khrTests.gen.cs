// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "DevicePciBusInfoKHR"/> struct.</summary>
public static unsafe partial class _cl_device_pci_bus_info_khrTests
{
    /// <summary>Validates that the <see cref = "DevicePciBusInfoKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DevicePciBusInfoKHR>(), Is.EqualTo(sizeof(DevicePciBusInfoKHR)));
    }

    /// <summary>Validates that the <see cref = "DevicePciBusInfoKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DevicePciBusInfoKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DevicePciBusInfoKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DevicePciBusInfoKHR), Is.EqualTo(16));
    }
}
