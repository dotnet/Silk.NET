// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PipelineRasterizationDepthClipStateCreateInfoEXT"/> struct.</summary>
public static unsafe partial class VkPipelineRasterizationDepthClipStateCreateInfoEXTTests
{
    /// <summary>Validates that the <see cref = "PipelineRasterizationDepthClipStateCreateInfoEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PipelineRasterizationDepthClipStateCreateInfoEXT>(),
            Is.EqualTo(sizeof(PipelineRasterizationDepthClipStateCreateInfoEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PipelineRasterizationDepthClipStateCreateInfoEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(PipelineRasterizationDepthClipStateCreateInfoEXT).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "PipelineRasterizationDepthClipStateCreateInfoEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PipelineRasterizationDepthClipStateCreateInfoEXT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PipelineRasterizationDepthClipStateCreateInfoEXT), Is.EqualTo(16));
        }
    }
}
