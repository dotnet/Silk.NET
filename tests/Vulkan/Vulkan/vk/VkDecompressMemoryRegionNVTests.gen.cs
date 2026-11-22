// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DecompressMemoryRegionNV"/> struct.</summary>
public static unsafe partial class VkDecompressMemoryRegionNVTests
{
    /// <summary>Validates that the <see cref = "DecompressMemoryRegionNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DecompressMemoryRegionNV>(),
            Is.EqualTo(sizeof(DecompressMemoryRegionNV))
        );
    }

    /// <summary>Validates that the <see cref = "DecompressMemoryRegionNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DecompressMemoryRegionNV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DecompressMemoryRegionNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DecompressMemoryRegionNV), Is.EqualTo(40));
    }
}
