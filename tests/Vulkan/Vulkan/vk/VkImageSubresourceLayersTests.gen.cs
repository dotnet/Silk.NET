// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "ImageSubresourceLayers"/> struct.</summary>
public static unsafe partial class VkImageSubresourceLayersTests
{
    /// <summary>Validates that the <see cref = "ImageSubresourceLayers"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ImageSubresourceLayers>(),
            Is.EqualTo(sizeof(ImageSubresourceLayers))
        );
    }

    /// <summary>Validates that the <see cref = "ImageSubresourceLayers"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ImageSubresourceLayers).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ImageSubresourceLayers"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ImageSubresourceLayers), Is.EqualTo(16));
    }
}
