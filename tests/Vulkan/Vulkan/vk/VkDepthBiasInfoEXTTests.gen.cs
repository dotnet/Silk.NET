// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "DepthBiasInfoEXT"/> struct.</summary>
public static unsafe partial class VkDepthBiasInfoEXTTests
{
    /// <summary>Validates that the <see cref = "DepthBiasInfoEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DepthBiasInfoEXT>(), Is.EqualTo(sizeof(DepthBiasInfoEXT)));
    }

    /// <summary>Validates that the <see cref = "DepthBiasInfoEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DepthBiasInfoEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DepthBiasInfoEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DepthBiasInfoEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DepthBiasInfoEXT), Is.EqualTo(20));
        }
    }
}
