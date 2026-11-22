// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "ColorBlendAdvancedEXT"/> struct.</summary>
public static unsafe partial class VkColorBlendAdvancedEXTTests
{
    /// <summary>Validates that the <see cref = "ColorBlendAdvancedEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ColorBlendAdvancedEXT>(),
            Is.EqualTo(sizeof(ColorBlendAdvancedEXT))
        );
    }

    /// <summary>Validates that the <see cref = "ColorBlendAdvancedEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ColorBlendAdvancedEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ColorBlendAdvancedEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ColorBlendAdvancedEXT), Is.EqualTo(20));
    }
}
