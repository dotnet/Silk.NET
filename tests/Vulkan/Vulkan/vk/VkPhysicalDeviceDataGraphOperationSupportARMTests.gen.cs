// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PhysicalDeviceDataGraphOperationSupportARM"/> struct.</summary>
public static unsafe partial class VkPhysicalDeviceDataGraphOperationSupportARMTests
{
    /// <summary>Validates that the <see cref = "PhysicalDeviceDataGraphOperationSupportARM"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PhysicalDeviceDataGraphOperationSupportARM>(),
            Is.EqualTo(sizeof(PhysicalDeviceDataGraphOperationSupportARM))
        );
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceDataGraphOperationSupportARM"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PhysicalDeviceDataGraphOperationSupportARM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PhysicalDeviceDataGraphOperationSupportARM"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PhysicalDeviceDataGraphOperationSupportARM), Is.EqualTo(136));
    }
}
