// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PipelineDiscardRectangleStateCreateInfoEXT"/> struct.</summary>
public static unsafe partial class VkPipelineDiscardRectangleStateCreateInfoEXTTests
{
    /// <summary>Validates that the <see cref = "PipelineDiscardRectangleStateCreateInfoEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PipelineDiscardRectangleStateCreateInfoEXT>(),
            Is.EqualTo(sizeof(PipelineDiscardRectangleStateCreateInfoEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PipelineDiscardRectangleStateCreateInfoEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PipelineDiscardRectangleStateCreateInfoEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PipelineDiscardRectangleStateCreateInfoEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PipelineDiscardRectangleStateCreateInfoEXT), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(PipelineDiscardRectangleStateCreateInfoEXT), Is.EqualTo(24));
        }
    }
}
