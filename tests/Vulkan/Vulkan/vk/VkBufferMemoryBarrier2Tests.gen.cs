// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "BufferMemoryBarrier2"/> struct.</summary>
public static unsafe partial class VkBufferMemoryBarrier2Tests
{
    /// <summary>Validates that the <see cref = "BufferMemoryBarrier2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<BufferMemoryBarrier2>(),
            Is.EqualTo(sizeof(BufferMemoryBarrier2))
        );
    }

    /// <summary>Validates that the <see cref = "BufferMemoryBarrier2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BufferMemoryBarrier2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BufferMemoryBarrier2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BufferMemoryBarrier2), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(BufferMemoryBarrier2), Is.EqualTo(72));
        }
    }
}
