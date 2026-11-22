// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "SharedPresentSurfaceCapabilitiesKHR"/> struct.</summary>
public static unsafe partial class VkSharedPresentSurfaceCapabilitiesKHRTests
{
    /// <summary>Validates that the <see cref = "SharedPresentSurfaceCapabilitiesKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SharedPresentSurfaceCapabilitiesKHR>(),
            Is.EqualTo(sizeof(SharedPresentSurfaceCapabilitiesKHR))
        );
    }

    /// <summary>Validates that the <see cref = "SharedPresentSurfaceCapabilitiesKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SharedPresentSurfaceCapabilitiesKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SharedPresentSurfaceCapabilitiesKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SharedPresentSurfaceCapabilitiesKHR), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SharedPresentSurfaceCapabilitiesKHR), Is.EqualTo(12));
        }
    }
}
