// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "HostAddressRangeConstEXT"/> struct.</summary>
public static unsafe partial class VkHostAddressRangeConstEXTTests
{
    /// <summary>Validates that the <see cref = "HostAddressRangeConstEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HostAddressRangeConstEXT>(),
            Is.EqualTo(sizeof(HostAddressRangeConstEXT))
        );
    }

    /// <summary>Validates that the <see cref = "HostAddressRangeConstEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HostAddressRangeConstEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HostAddressRangeConstEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HostAddressRangeConstEXT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(HostAddressRangeConstEXT), Is.EqualTo(8));
        }
    }
}
