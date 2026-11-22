// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "BindShaderGroupIndirectCommandNV"/> struct.</summary>
public static unsafe partial class VkBindShaderGroupIndirectCommandNVTests
{
    /// <summary>Validates that the <see cref = "BindShaderGroupIndirectCommandNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<BindShaderGroupIndirectCommandNV>(),
            Is.EqualTo(sizeof(BindShaderGroupIndirectCommandNV))
        );
    }

    /// <summary>Validates that the <see cref = "BindShaderGroupIndirectCommandNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BindShaderGroupIndirectCommandNV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BindShaderGroupIndirectCommandNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BindShaderGroupIndirectCommandNV), Is.EqualTo(4));
    }
}
