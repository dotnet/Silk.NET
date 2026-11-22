// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "BindVertexBuffer3InfoKHR"/> struct.</summary>
public static unsafe partial class VkBindVertexBuffer3InfoKHRTests
{
    /// <summary>Validates that the <see cref = "BindVertexBuffer3InfoKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<BindVertexBuffer3InfoKHR>(),
            Is.EqualTo(sizeof(BindVertexBuffer3InfoKHR))
        );
    }

    /// <summary>Validates that the <see cref = "BindVertexBuffer3InfoKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BindVertexBuffer3InfoKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BindVertexBuffer3InfoKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BindVertexBuffer3InfoKHR), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(BindVertexBuffer3InfoKHR), Is.EqualTo(48));
        }
    }
}
