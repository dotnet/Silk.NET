// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "PastPresentationTimingPropertiesEXT"/> struct.</summary>
public static unsafe partial class VkPastPresentationTimingPropertiesEXTTests
{
    /// <summary>Validates that the <see cref = "PastPresentationTimingPropertiesEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PastPresentationTimingPropertiesEXT>(),
            Is.EqualTo(sizeof(PastPresentationTimingPropertiesEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PastPresentationTimingPropertiesEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PastPresentationTimingPropertiesEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PastPresentationTimingPropertiesEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PastPresentationTimingPropertiesEXT), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(PastPresentationTimingPropertiesEXT), Is.EqualTo(32));
        }
    }
}
