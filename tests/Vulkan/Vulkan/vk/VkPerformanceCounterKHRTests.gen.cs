// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PerformanceCounterKHR"/> struct.</summary>
public static unsafe partial class VkPerformanceCounterKHRTests
{
    /// <summary>Validates that the <see cref = "PerformanceCounterKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PerformanceCounterKHR>(),
            Is.EqualTo(sizeof(PerformanceCounterKHR))
        );
    }

    /// <summary>Validates that the <see cref = "PerformanceCounterKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PerformanceCounterKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PerformanceCounterKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PerformanceCounterKHR), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(PerformanceCounterKHR), Is.EqualTo(36));
        }
    }
}
