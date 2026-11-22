// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DecompressMemoryInfoEXT"/> struct.</summary>
public static unsafe partial class VkDecompressMemoryInfoEXTTests
{
    /// <summary>Validates that the <see cref = "DecompressMemoryInfoEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DecompressMemoryInfoEXT>(),
            Is.EqualTo(sizeof(DecompressMemoryInfoEXT))
        );
    }

    /// <summary>Validates that the <see cref = "DecompressMemoryInfoEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DecompressMemoryInfoEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DecompressMemoryInfoEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DecompressMemoryInfoEXT), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DecompressMemoryInfoEXT), Is.EqualTo(24));
        }
    }
}
