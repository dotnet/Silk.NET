// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PipelineDynamicStateCreateInfo"/> struct.</summary>
public static unsafe partial class VkPipelineDynamicStateCreateInfoTests
{
    /// <summary>Validates that the <see cref = "PipelineDynamicStateCreateInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PipelineDynamicStateCreateInfo>(),
            Is.EqualTo(sizeof(PipelineDynamicStateCreateInfo))
        );
    }

    /// <summary>Validates that the <see cref = "PipelineDynamicStateCreateInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PipelineDynamicStateCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PipelineDynamicStateCreateInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PipelineDynamicStateCreateInfo), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PipelineDynamicStateCreateInfo), Is.EqualTo(20));
        }
    }
}
