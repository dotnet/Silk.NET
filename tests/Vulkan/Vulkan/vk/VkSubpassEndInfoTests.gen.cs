// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "SubpassEndInfo"/> struct.</summary>
public static unsafe partial class VkSubpassEndInfoTests
{
    /// <summary>Validates that the <see cref = "SubpassEndInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SubpassEndInfo>(), Is.EqualTo(sizeof(SubpassEndInfo)));
    }

    /// <summary>Validates that the <see cref = "SubpassEndInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SubpassEndInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SubpassEndInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SubpassEndInfo), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SubpassEndInfo), Is.EqualTo(8));
        }
    }
}
