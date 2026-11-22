// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "ClearValue"/> struct.</summary>
public static unsafe partial class VkClearValueTests
{
    /// <summary>Validates that the <see cref = "ClearValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ClearValue>(), Is.EqualTo(sizeof(ClearValue)));
    }

    /// <summary>Validates that the <see cref = "ClearValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(ClearValue).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "ClearValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ClearValue), Is.EqualTo(16));
    }
}
