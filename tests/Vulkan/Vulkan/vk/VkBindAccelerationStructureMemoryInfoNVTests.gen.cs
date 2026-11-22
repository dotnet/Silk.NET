// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "BindAccelerationStructureMemoryInfoNV"/> struct.</summary>
public static unsafe partial class VkBindAccelerationStructureMemoryInfoNVTests
{
    /// <summary>Validates that the <see cref = "BindAccelerationStructureMemoryInfoNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<BindAccelerationStructureMemoryInfoNV>(),
            Is.EqualTo(sizeof(BindAccelerationStructureMemoryInfoNV))
        );
    }

    /// <summary>Validates that the <see cref = "BindAccelerationStructureMemoryInfoNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BindAccelerationStructureMemoryInfoNV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BindAccelerationStructureMemoryInfoNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BindAccelerationStructureMemoryInfoNV), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(BindAccelerationStructureMemoryInfoNV), Is.EqualTo(32));
        }
    }
}
