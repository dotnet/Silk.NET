// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "ViewportSwizzleNV"/> struct.</summary>
public static unsafe partial class VkViewportSwizzleNVTests
{
    /// <summary>Validates that the <see cref = "ViewportSwizzleNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ViewportSwizzleNV>(), Is.EqualTo(sizeof(ViewportSwizzleNV)));
    }

    /// <summary>Validates that the <see cref = "ViewportSwizzleNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ViewportSwizzleNV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ViewportSwizzleNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ViewportSwizzleNV), Is.EqualTo(16));
    }
}
