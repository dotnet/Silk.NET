// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "CuLaunchInfoNVX"/> struct.</summary>
public static unsafe partial class VkCuLaunchInfoNVXTests
{
    /// <summary>Validates that the <see cref = "CuLaunchInfoNVX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CuLaunchInfoNVX>(), Is.EqualTo(sizeof(CuLaunchInfoNVX)));
    }

    /// <summary>Validates that the <see cref = "CuLaunchInfoNVX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CuLaunchInfoNVX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CuLaunchInfoNVX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CuLaunchInfoNVX), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(CuLaunchInfoNVX), Is.EqualTo(56));
        }
    }
}
