// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "IndirectCommandsIndexBufferTokenEXT"/> struct.</summary>
public static unsafe partial class VkIndirectCommandsIndexBufferTokenEXTTests
{
    /// <summary>Validates that the <see cref = "IndirectCommandsIndexBufferTokenEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IndirectCommandsIndexBufferTokenEXT>(),
            Is.EqualTo(sizeof(IndirectCommandsIndexBufferTokenEXT))
        );
    }

    /// <summary>Validates that the <see cref = "IndirectCommandsIndexBufferTokenEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IndirectCommandsIndexBufferTokenEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IndirectCommandsIndexBufferTokenEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IndirectCommandsIndexBufferTokenEXT), Is.EqualTo(4));
    }
}
