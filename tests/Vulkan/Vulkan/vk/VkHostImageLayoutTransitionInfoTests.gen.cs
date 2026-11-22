// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "HostImageLayoutTransitionInfo"/> struct.</summary>
public static unsafe partial class VkHostImageLayoutTransitionInfoTests
{
    /// <summary>Validates that the <see cref = "HostImageLayoutTransitionInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HostImageLayoutTransitionInfo>(),
            Is.EqualTo(sizeof(HostImageLayoutTransitionInfo))
        );
    }

    /// <summary>Validates that the <see cref = "HostImageLayoutTransitionInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HostImageLayoutTransitionInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HostImageLayoutTransitionInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HostImageLayoutTransitionInfo), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(HostImageLayoutTransitionInfo), Is.EqualTo(40));
        }
    }
}
